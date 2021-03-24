﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

using DevApp.SQLite.Queries;

namespace DevApp.Child_Forms
{
    public partial class XtraMDICaixaHistory : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo CultureBR = new CultureInfo("pt-BR");
        private clsCaixaHistQueries CaixaHistQueries = new clsCaixaHistQueries();

        frmMain Main;

        public XtraMDICaixaHistory(frmMain _Main)
        {
            InitializeComponent();

            this.Main = _Main;
        }

        private void ListarCaixas()
        {
            DataTable dt = CaixaHistQueries.ListarCaixas();
            gridCaixaHist.DataSource = dt;
        }

        private void FiltrarCaixas(int Tipo)
        {
            switch (Tipo)
            {
                case 0:
                    {
                        ListarCaixas();
                        break;
                    }
                case 1:
                    {
                        DataTable dt = CaixaHistQueries.ListarPorPeriodo(dateHistPesqInicio.Text, dateHistPesqFim.Text);
                        gridCaixaHist.DataSource = dt;

                        break;
                    }
                case 2:
                    {
                        DataTable dt = CaixaHistQueries.ListarPorUsuario(comboHistPesqFuncionario.Text);
                        gridCaixaHist.DataSource = dt;

                        break;
                    }
                default:break;
            }
        }

        private void XtraMDICaixaHistory_Load(object sender, EventArgs e)
        {
            radioCaixaLogPesquisa.EditValue = 0;

            dateHistPesqInicio.DateTime = DateTime.Now;
            dateHistPesqFim.DateTime = DateTime.Now;

            lblHistPesqFilter.Visible = true;
            lblHistPesqFilter.Top = lblHistPesqInicio.Top + 10;

            ListarCaixas();
        }

        private void radioCaixaLogPesquisa_EditValueChanged(object sender, EventArgs e)
        {
            switch (radioCaixaLogPesquisa.EditValue)
            {
               case 0:
                    {
                        lblHistPesqInicio.Visible = false;
                        lblHistPesqFim.Visible = false;
                        dateHistPesqInicio.Visible = false;
                        dateHistPesqFim.Visible = false;

                        lblHistPesqFuncionario.Visible = false;
                        comboHistPesqFuncionario.Visible = false;

                        lblHistPesqFilter.Visible = true;
                        lblHistPesqFilter.Top = lblHistPesqInicio.Top + 10;

                        gridViewCaixaHist.ActiveFilterString = "";

                        break;
                    }
                case 1:
                    {
                        lblHistPesqInicio.Visible = true;
                        lblHistPesqFim.Visible = true;
                        dateHistPesqInicio.Visible = true;
                        dateHistPesqFim.Visible = true;

                        lblHistPesqFuncionario.Visible = false;
                        comboHistPesqFuncionario.Visible = false;

                        lblHistPesqFilter.Visible = false;
                        lblHistPesqFilter.Top = lblHistPesqInicio.Top + 10;

                        gridViewCaixaHist.ActiveFilterString = "";

                        break;
                    }
                case 2:
                    {
                        lblHistPesqInicio.Visible = false;
                        lblHistPesqFim.Visible = false;
                        dateHistPesqInicio.Visible = false;
                        dateHistPesqFim.Visible = false;

                        lblHistPesqFuncionario.Visible = true;
                        comboHistPesqFuncionario.Visible = true;

                        lblHistPesqFilter.Visible = false;

                        lblHistPesqFuncionario.Top = lblHistPesqInicio.Top;
                        comboHistPesqFuncionario.Top = dateHistPesqInicio.Top;

                        gridViewCaixaHist.ActiveFilterString = "";

                        break;
                    }
            }

            FiltrarCaixas(Int32.Parse(radioCaixaLogPesquisa.EditValue.ToString())) ;
        }

        private void gridViewCaixaHist_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if ((e.Column.FieldName == "startvalue" 
                || e.Column.FieldName == "endvalue" 
                || e.Column.FieldName == "endvalueuser"
                || e.Column.FieldName == "sangria"
                || e.Column.FieldName == "despesas"
                || e.Column.FieldName == "acrecimos") && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                decimal price = Convert.ToDecimal(e.Value);
                e.DisplayText = string.Format(CultureBR, "{0:c}", price);
            }
        }

        private void gridViewCaixaHist_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            Brush brush;

            if (e.Column.FieldName == "id")
            {
                brush = new SolidBrush(Color.Gray);
                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                e.Handled = true;
            }

            if (e.Column.FieldName == "isopen")
            {
                if (e.DisplayText == "0")
                {
                    e.DisplayText = "Fechado";
                    brush = new SolidBrush(Color.OrangeRed);
                }
                else
                {
                    e.DisplayText = "Aberto";
                    brush = new SolidBrush(Color.Green);
                }

                Rectangle r = e.Bounds;
                e.Graphics.FillRectangle(brush, r.X, r.Y, 3, r.Height);
                e.Appearance.DrawString(e.Cache, "    " + e.DisplayText, r);
                e.Handled = true;
            }
        }

        private void gridViewCaixaHist_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewCaixaHist.FocusedRowHandle >= 0)
            {
                string Status = gridViewCaixaHist.GetRowCellValue(gridViewCaixaHist.FocusedRowHandle, "isopen").ToString();
                if (Int32.Parse(Status) == 1)
                {
                    this.Main.ShowCurrentCaixa();

                } else
                {
                    int CaixaId = Int32.Parse(gridViewCaixaHist.GetFocusedRowCellValue("id").ToString());
                    this.Main.ShowCustomCaixa(CaixaId);
                }
            }
        }

        private void btnPrintHist_Click(object sender, EventArgs e)
        {
            if (!gridCaixaHist.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            gridViewCaixaHist.ShowPrintPreview();
        }

        private void dateHistPesqInicio_TextChanged(object sender, EventArgs e)
        {
            FiltrarCaixas(Int32.Parse(radioCaixaLogPesquisa.EditValue.ToString()));
        }

        private void dateHistPesqFim_TextChanged(object sender, EventArgs e)
        {
            FiltrarCaixas(Int32.Parse(radioCaixaLogPesquisa.EditValue.ToString()));
        }

        private void comboHistPesqFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarCaixas(Int32.Parse(radioCaixaLogPesquisa.EditValue.ToString()));
        }
    }
}