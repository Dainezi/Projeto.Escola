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
    public partial class Materia : Form
    {
        public static List<Model.Materia> listagemM = new List<Model.Materia>();
        public Materia()
        {
            InitializeComponent();
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            var materia = new Model.Materia();
            {
                materia.NomeMateria = Txt_Nome.Text;
                materia.IdMateria = int.Parse(Txt_Codigo.Text);
                materia.SituacaoMateria = Txt_Situacao.Text;
                materia.IdCurso = int.Parse(Txt_Curso.Text);
            }

            var content = JsonConvert.SerializeObject(materia);
            var URL = "https://localhost:44306/Materia/postMateria";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagemM = JsonConvert.DeserializeObject<List<Model.Materia>>(result.Result);
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            var materia = new Model.Materia();
            {
                materia.NomeMateria = Txt_Nome.Text;
                materia.IdMateria = int.Parse(Txt_Codigo.Text);
                materia.SituacaoMateria = Txt_Situacao.Text;
                materia.IdCurso = int.Parse(Txt_Curso.Text);
            }

            var materianovo = listagemM.FirstOrDefault(s => s.IdMateria == materia.IdMateria);
            if (materianovo != null)
            {
                materianovo.NomeMateria = Txt_Nome.Text;
                materianovo.IdMateria = int.Parse(Txt_Codigo.Text);
                materianovo.SituacaoMateria = Txt_Situacao.Text;
                materianovo.IdCurso = int.Parse(Txt_Curso.Text);
            }

            var content = JsonConvert.SerializeObject(materianovo);
            var URL = "https://localhost:44306/Materia/postAlterarMateria";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagemM = JsonConvert.DeserializeObject<List<Model.Materia>>(result.Result);
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            var materia = new Model.Materia();
            {
                materia.IdMateria = int.Parse(Txt_CodigoRemove.Text);
            }

            var cursodel = listagemM.RemoveAll(s => s.IdMateria == materia.IdMateria);

            var URL = "https://localhost:44306/Materia/deleteMateria";

            var httpClient = new HttpClient();
            var resultRequest = httpClient.DeleteAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            listagemM = JsonConvert.DeserializeObject<List<Model.Materia>>(result.Result);
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:44306/Materia/listarMateria";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();

            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            var data = JsonConvert.DeserializeObject<List<Model.Materia>>(result.Result);
            List<Model.Materia> lista = new List<Model.Materia>();

            foreach (var materia in data)
            {
                lista.Add(materia);
            }

            Txt_Listar.Text += lista;
        }
    }
}
