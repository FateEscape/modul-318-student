
using System;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net.Mail;
namespace StationLocator;


public partial class Form1 : Form
{
    private readonly ITransport transport = new Transport();
    public Form1()
    {
        InitializeComponent();
        this.TextStartStation.AutoCompleteMode = AutoCompleteMode.Suggest;
        this.TextStartStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
        this.TextStartStation.AutoCompleteCustomSource = new AutoCompleteStringCollection();
    }

    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void panel12_Paint(object sender, PaintEventArgs e)
    {
        
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void TextStartStation_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.TextStartStation.Text))
        {
            return;
        }

        string stationQuery = this.TextStartStation.Text;

        Stations result = this.transport.GetStations(stationQuery);

        // This can also be done using linq extension methods.
        var autoCompleteCustomSource = new List<string>();
        foreach (Station station in result.StationList)
        {
            autoCompleteCustomSource.Add(station.Name);
        }

        this.TextStartStation.AutoCompleteCustomSource.Clear();
        this.TextStartStation.AutoCompleteCustomSource.AddRange(autoCompleteCustomSource.ToArray());
    }

    private void panel13_Paint(object sender, PaintEventArgs e)
    {
        
            if (TextStartStation.Text != "")
            {
                panel13.BackColor = Color.DodgerBlue;
            }
    
        
    }

    private void Losfahrenbt_Click(object sender, EventArgs e)
    {
       

        string Von = TextStartStation.Text;
        string Nach = TextEndStation.Text;
        Connections Connection = this.transport
               .GetConnections(Von, Nach);

        var values = Connection.ConnectionList
                .Select(x => new Connection(x.To.Station.Name, x.From.Station.Name, TimeSpan.Parse(x.Duration.Replace("00d", string.Empty)).ToString(),
                x.From.Departure?.ToString("hh:mm") ?? string.Empty, x.To.Arrival?.ToString("hh:mm") ?? string.Empty))
                .ToList();

        int count = 0;
        var connectList = new BindingList<Connection>((IList<Connection>)values);
        foreach (var x in connectList)
        {
            if (count == 0)
            {
                Verbindung1.Text = $"{x.Von} -  {x.Nach}    Fahrtdauer: {x.Zeit}\n " +
                                  $"{x.Fährtabam} - {x.Kommtanan}";
                Verbindung1.Visible = true;
            }
            else if (count == 1)
            {
                Verbindung2.Text = $"{x.Von} -  {x.Nach}    Fahrtdauer: {x.Zeit}\n " +
                                  $"{x.Fährtabam} - {x.Kommtanan}";
                Verbindung2.Visible = true;
            }
            else if (count == 2)
            {
                Verbindung3.Text = $"{x.Von} -  {x.Nach}    Fahrtdauer: {x.Zeit}\n " +
                                  $"{x.Fährtabam} - {x.Kommtanan}";
                Verbindung3.Visible = true;
            }
            else if (count == 3)
            {
                Verbindung4.Text = $"{x.Von} -  {x.Nach}    Fahrtdauer: {x.Zeit}\n " +
                                  $"{x.Fährtabam} - {x.Kommtanan}";
                Verbindung4.Visible = true;
                break;
            }
            count++;
        }
    }

    private void Verbindung1_Click(object sender, EventArgs e)
    {

    }

    private void panel14_Paint(object sender, PaintEventArgs e)
    {
        if (TextEndStation.Text != "")
        {
            panel14.BackColor = Color.DodgerBlue;
        }
    }

    private void panel16_Paint(object sender, PaintEventArgs e)
    {
        if (Zeittb.Text != "")
        {
            panel16.BackColor = Color.DodgerBlue;
        }
    }

    private void panel15_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        MailAddress from = new MailAddress(HostEmailtb.Text, Betrefftb.Text);
        MailAddress to = new MailAddress("Joshua@Jochum.ai", Betrefftb.Text);
        List<MailAddress> cc = new List<MailAddress>();
        cc.Add(new MailAddress("Joshua@Jochum.ai", Betrefftb.Text));
        SendEmail(Anliegentb.Text, from, to, cc);
    }



    private record Connection(string Nach, string Von, string Zeit, string Fährtabam, string Kommtanan);

    private record RecordGridTabelle(string id);

    private record RecordGridTafel(string Zuständiger, string Zug, string Richtung);

    private void Passwordtb_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        
        panel4.BackColor = Color.Red;
        panel5.BackColor = Color.Red;
        panel6.BackColor = Color.Red;
        panel7.BackColor = Color.Red;
        panel8.BackColor = Color.Red;
        panel9.BackColor = Color.Red;
        panel10.BackColor = Color.Red;
        panel11.BackColor = Color.Red;
        panel13.BackColor = Color.Red;
        panel14.BackColor = Color.Red;
        panel15.BackColor = Color.Red;
        panel16.BackColor = Color.Red;
        panel17.BackColor = Color.Red;


        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        panel4.BackColor = Color.ForestGreen;
        panel5.BackColor = Color.ForestGreen;
        panel6.BackColor = Color.ForestGreen;
        panel7.BackColor = Color.ForestGreen;
        panel8.BackColor = Color.ForestGreen;
        panel9.BackColor = Color.ForestGreen;
        panel10.BackColor = Color.ForestGreen;
        panel11.BackColor = Color.ForestGreen;
        panel13.BackColor = Color.ForestGreen;
        panel14.BackColor = Color.ForestGreen;
        panel15.BackColor = Color.ForestGreen;
        panel16.BackColor = Color.ForestGreen;
        panel17.BackColor = Color.ForestGreen;
    }

    private void Stationsuchenknopf_Click(object sender, EventArgs e)
    {
        try
        {
            string station = this.Stationsuchentb.Text;

            Stations Station = this.transport
                .GetStations(station);
            VerbindungenGrid.Visible = true;

            

            var foo = Station.StationList
            .First();


            StationBoardRoot StationBoardRoot = this.transport
                .GetStationBoard(foo.Name, foo.Id);



            var values = StationBoardRoot.Entries
                .Select(y => new RecordGridTafel(y.Operator, $"{y.Category}{y.Number}", y.To))
                .ToList();

            var stList = new BindingList<RecordGridTafel>(values);
            VerbindungenGrid.DataSource = stList;
        }
        catch (Exception ex)
        { MessageBox.Show(ex.Message); }
    }

    private void VerbindungenGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        panel4.BackColor = Color.DodgerBlue;
        panel5.BackColor = Color.DodgerBlue;
        panel6.BackColor = Color.DodgerBlue;
        panel7.BackColor = Color.DodgerBlue;
        panel8.BackColor = Color.DodgerBlue;
        panel9.BackColor = Color.DodgerBlue;
        panel10.BackColor = Color.DodgerBlue;
        panel11.BackColor = Color.DodgerBlue;
        panel13.BackColor = Color.DodgerBlue;
        panel14.BackColor = Color.DodgerBlue;
        panel15.BackColor = Color.DodgerBlue;
        panel16.BackColor = Color.DodgerBlue;
        panel17.BackColor = Color.DodgerBlue;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        panel4.BackColor = Color.Cyan;
        panel5.BackColor = Color.Cyan;
        panel6.BackColor = Color.Cyan;
        panel7.BackColor = Color.Cyan;
        panel8.BackColor = Color.Cyan;
        panel9.BackColor = Color.Cyan;
        panel10.BackColor = Color.Cyan;
        panel11.BackColor = Color.Cyan;
        panel13.BackColor = Color.Cyan;
        panel14.BackColor = Color.Cyan;
        panel15.BackColor = Color.Cyan;
        panel16.BackColor = Color.Cyan;
        panel17.BackColor = Color.Cyan;

    }

    protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)

    {
        string Text = "";
        SmtpClient mailClient = new SmtpClient("smtp.live.com", 25);
        mailClient.EnableSsl = true;
        mailClient.Credentials = new System.Net.NetworkCredential(HostEmailtb.Text, Passwordtb.Text);
        MailMessage msgMail;
        Text = Anliegentb.Text;
        msgMail = new MailMessage();
        msgMail.From = _from;
        msgMail.To.Add(_to);
        foreach (MailAddress addr in _cc)
        {
            msgMail.CC.Add(addr);
        }
        if (_bcc != null)
        {
            foreach (MailAddress addr in _bcc)
            {
                msgMail.Bcc.Add(addr);
            }
        }
        msgMail.Subject = _subject;
        msgMail.Body = Text;
        msgMail.IsBodyHtml = true;
        mailClient.Send(msgMail);
        msgMail.Dispose();
    }
}

