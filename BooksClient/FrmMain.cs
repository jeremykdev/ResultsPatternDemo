using System.Text.Json;
using Ardalis.Result;
using BooksClient.ApiClients;

namespace BooksClient;

public partial class FrmMain : Form
{
    protected NaiveApiClient naiveApiClient = new();
    protected ArdalisResultApiClient ardalisResultApiClient = new();
    protected OneOfApiClient oneOfApiClient = new();
    protected JsonSerializerOptions jsonSerializerOptions = new() { PropertyNameCaseInsensitive = true, WriteIndented = true };

    public FrmMain()
    {
        InitializeComponent();
    }

    protected string ToJson(object obj)
    {
        string json = JsonSerializer.Serialize(obj, this.jsonSerializerOptions);
        return json;
    }


    protected void UnlockUi()
    {
        this.rdoGetAllBooks.Enabled = true;
        this.rdoGetBookById.Enabled = true;
        this.txtBookId.Enabled = true;
        this.btnNiaveApiClient.Enabled = true;
        this.btnArdalisResultClient.Enabled = true;
        this.btnOneOfApiClient.Enabled = true;
    }

    protected void LockUi()
    {
        this.rdoGetAllBooks.Enabled = false;
        this.rdoGetBookById.Enabled = false;
        this.txtBookId.Enabled = false;
        this.btnNiaveApiClient.Enabled = false;
        this.btnArdalisResultClient.Enabled = false;
        this.btnOneOfApiClient.Enabled = false;
    }

    private async void btnNiaveApiClient_Click(object sender, EventArgs e)
    {
        this.LockUi();
        this.txtOutput.Clear();

        string output = null;        

        if (rdoGetAllBooks.Checked)
        {
            output = this.ToJson(await this.naiveApiClient.GetAllBooks());
        }
        else
        {
            output = this.ToJson(await this.naiveApiClient.GetBookById(this.txtBookId.Text));
        }

        this.txtOutput.Text = output;

        this.UnlockUi();
    }

    private async void btnArdalisResultClient_Click(object sender, EventArgs e)
    {
        this.LockUi();
        this.txtOutput.Clear();

        string output = null;

        if (rdoGetAllBooks.Checked)
        {
            var result = await this.ardalisResultApiClient.GetAllBooks();
            
            if (result.IsSuccess)
                output = ToJson(result.Value);
            else
                output = result.Status.ToString();
        }
        else
        {
            var result = await this.ardalisResultApiClient.GetBookById(this.txtBookId.Text);
           
            if (result.IsSuccess)
                output = ToJson(result.Value);
            else           
                output = result.Status.ToString();
               
        }

        this.txtOutput.Text = output;

        this.UnlockUi();
    }

    private async void btnOneOfApiClient_Click(object sender, EventArgs e)
    {
        this.LockUi();
        this.txtOutput.Clear();

        string output = null;

        if (rdoGetAllBooks.Checked)
        {
            var result = await this.oneOfApiClient.GetAllBooks();

            output = result.Match<string>(
                    books => ToJson(books),
                    notFound => "Not Found",
                    error => "Error"
                );           
        }
        else
        {
            var result = await this.oneOfApiClient.GetBookById(this.txtBookId.Text);

            output = result.Match<string>(
                    book => ToJson(book),
                    notFound => "Not Found",
                    error => "Error"
                );
        }

        this.txtOutput.Text = output;

        this.UnlockUi();
    }
}
