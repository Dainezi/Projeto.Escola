using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Maestro.Escola.Forms
{
    public partial class Curso : Form
    {
        public static List<Model.Curso> listagem = new List<Model.Curso>();
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
            var URL = "https://localhost:63169/Curso/postCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagem = JsonConvert.DeserializeObject<List<Model.Curso>>(result.Result);

        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            var curso = new Model.Curso();
            {
                curso.NomeCurso = Txt_Nome.Text;
                curso.IdCurso = int.Parse(Txt_Codigo.Text);
                curso.SituacaoCurso = Txt_Situacao.Text;
            }

            var cursonovo = listagem.FirstOrDefault(s => s.IdCurso == curso.IdCurso);
            if (cursonovo != null)
            {
                cursonovo.NomeCurso = Txt_Nome.Text;
                cursonovo.IdCurso = int.Parse(Txt_Codigo.Text);
                cursonovo.SituacaoCurso = Txt_Situacao.Text;
            }

            var content = JsonConvert.SerializeObject(cursonovo);
            var URL = "https://localhost:63169/Curso/postAlterarCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagem = JsonConvert.DeserializeObject<List<Model.Curso>>(result.Result);
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            var curso = new Model.Curso();
            {
                curso.IdCurso = int.Parse(Txt_CodigoRemove.Text);
            }

            var cursodel = listagem.RemoveAll(s => s.IdCurso == curso.IdCurso);

            var URL = "https://localhost:63169/Curso/deleteCurso";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagem = JsonConvert.DeserializeObject<List<Model.Curso>>(result.Result);
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:63169/Curso/listarCurso";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Model.Curso>>(result.Result);
            List<Model.Curso> lista = new List<Model.Curso>();

            foreach (var curso in data)
            {
                lista.Add(curso);
            }

            Txt_Listar.Text += lista;
        }
    }
}
