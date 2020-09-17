using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Maestro.Escola.Forms
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            var curso = new Model.Curso();
            {
                curso.NomeCurso = Txt_Nome.Text;
                curso.IdCurso = int.Parse(Txt_Codigo.Text);
                curso.SituacaoCurso = Txt_Situacao.Text;
            }

            var content = JsonConvert.SerializeObject(curso);
            var URL = "https://localhost:44306/Curso/postCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var sualistagem = JsonConvert.DeserializeObject<List<Model.Curso>>(result.Result);

        }
    }
}
