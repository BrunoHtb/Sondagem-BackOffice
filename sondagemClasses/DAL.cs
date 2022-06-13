using System;
using System.Data;
using Npgsql;

namespace ProgFormularioEngenharia2
{
    class DAL
    {
        private string Host;
        private static string User = "postgres";
        private static string DBname = "sondagem";
        private static string Password = "admin";
        private static string Port = "5432";
        public static string connString;

        public DAL(string host)
        {
            this.Host = host;
            connectionDatabase();
        }

        ~DAL(){}

        public string GET()
        {
            return connString;
        }

        //CONEXÃO DE DATABASE
        private void connectionDatabase()
        {
            connString = String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4}",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);
        }

        //AUTENTICAÇÃO DE LOGIN
        public bool authenticLogin(string login, string password)
        {
            bool perm = false;
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    Console.Out.WriteLine("Opening connection");
                    conn.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM usuario", conn))
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            //Compara o login e senha inserido pelo usuario com os dados salvo no BD
                            if (login == reader.GetString(1) && password == reader.GetString(2))
                            {
                                perm = true;
                                break;
                            }
                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch{}
            return perm;
        }

        public void updateRegionalBD(string[] campo, string regional, DAL DBConnection)
        {
            string cmdAtualiza = string.Format("UPDATE public.sondagemdado SET regional='" + regional + "' WHERE nome LIKE ('"+ campo[0] + "')");

            using (var conn = new NpgsqlConnection(DBConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, conn))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        //SAVA OS DADOS DA PLANILHA .CSV NO BD
        public void saveDatabase(string[] campo)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                string foto = campo[12] + ";" + campo[14] + ";" + campo[16] + ";" + campo[18] + ";" + campo[20] + ";" + campo[22] + ";" + campo[24] + ";" + campo[26] + ";" + campo[28] + ";" + campo[30];
                string camada = campo[33] + ";" + campo[34] + ";" + campo[35] + ";" + campo[36];
                string espessura = campo[37] + ";" + campo[38] + ";" + campo[39] + ";" + campo[40];
                conn.Open();

                using (var command = new NpgsqlCommand(@"INSERT INTO sondagemdado(" +
                "nome, latitude_prevista, longitude_prevista, login, latitude, longitude, rodovia, km, metro, trecho, lote, foto, area, camada, espessura, status, observacao, entrega)" +
                "VALUES ( @n, @lap, @lop, @log, @lat, @lon, @rod, @km, @m, @tr, @lot, @fot, @area, @cam, @esp, @status, @obs, @entr) " +
                "ON CONFLICT (nome) DO NOTHING", conn))
                {
                    command.Parameters.AddWithValue("n", campo[1]);
                    command.Parameters.AddWithValue("lap", campo[2]);
                    command.Parameters.AddWithValue("lop", campo[3]);
                    command.Parameters.AddWithValue("log", campo[4]);
                    command.Parameters.AddWithValue("lat", campo[5]);
                    command.Parameters.AddWithValue("lon", campo[6]);
                    command.Parameters.AddWithValue("rod", campo[7]);
                    command.Parameters.AddWithValue("km", campo[8]);
                    command.Parameters.AddWithValue("m", campo[9]);
                    command.Parameters.AddWithValue("tr", campo[10]);
                    command.Parameters.AddWithValue("lot", campo[11]);
                    command.Parameters.AddWithValue("fot", foto);
                    command.Parameters.AddWithValue("area", campo[32]);
                    command.Parameters.AddWithValue("cam", camada);
                    command.Parameters.AddWithValue("esp", espessura);
                    command.Parameters.AddWithValue("status", campo[41]);
                    command.Parameters.AddWithValue("obs", campo[43]);
                    command.Parameters.AddWithValue("entr", "null");

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
                conn.Close();
            }
            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
        }

        public void editarDatabase(string cmdAtualiza, DAL DBConnection)
        {
            using (var conn = new NpgsqlConnection(DBConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, conn))
                {
                    pgsqlcommand.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void deletarDatabase(int idEditar, DAL DbConnection)
        {
            using (var conn = new NpgsqlConnection(DbConnection.GET()))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(String.Format("DELETE FROM sondagemdado WHERE id=" + idEditar), conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}


    

