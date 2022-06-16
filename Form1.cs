namespace projekPBO_Arisan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.db = new Model.DB();
            if(db.conn != null)
            {
                this.you = new Account(-1);
                this.you.user = new Model.Users(db);
                this.you.arisan = new Model.Arisan(db);
                this.you.anggota = new Model.Anggota(db);
                this.you.payment = new Model.Payment(db);
                this.you.winner = new Model.Winner(db);
            }
            else
            {
                MessageBox.Show("failed to connect to database");
            }
            InitializeComponent();
        }
        public void movetoMenu1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new menu1(this));
        }
        public void movetoLogin(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new login(this));
        }
        public void movetoSignup(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new signup(this));
        }
        public void movetoMenu2(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new menu2(this));
        }
        public void movetoAddArisan(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new addArisan(this));
        }
        public void movetoJoinArisan(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new joinArisan(this));
        }
    }
}