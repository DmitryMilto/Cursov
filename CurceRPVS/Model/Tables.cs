using System.Collections.Generic;
using System.Windows.Forms;

namespace CurceRPVS.Model
{
    class Tables
    {
        public List<DataGridViewTextBoxColumn> CreateTableColumn(Settings settings)
        {
            List<DataGridViewTextBoxColumn> column = new List<DataGridViewTextBoxColumn>();
            if (settings.time_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Текущее время";
                col0.Name = "ID";
                column.Add(col0);
            }
            if (settings.mass_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Масса";
                col0.Name = "mass";
                column.Add(col0);
            }
            if (settings.q_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Результат функции";
                col0.Name = "func";
                column.Add(col0);
            }
            if (settings.dq0_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Скорость";
                col0.Name = "dq0";
                column.Add(col0);
            }
            if (settings.c_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Коэффициент затухания";
                col0.Name = "c";
                column.Add(col0);
            }
            if (settings.w_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Круговая частота";
                col0.Name = "w";
                column.Add(col0);
            }
            if (settings.E_Check)
            {
                DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
                col0.HeaderText = "Параметр затухания";
                col0.Name = "e";
                column.Add(col0);
            }
            return column;
        }
        public List<DataGridViewRow> CreateTableRow(Phisics phisics, Settings settings)
        {
            List<DataGridViewRow> dataTable = new List<DataGridViewRow>();

            for (double t = 0; t < phisics.time; t += phisics.time_interval)
            {
                DataGridViewRow row = new DataGridViewRow();
                if (settings.time_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = t;
                    row.Cells.Add(columnValue);
                }
                if (settings.mass_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.m;
                    row.Cells.Add(columnValue);
                }
                if (settings.q_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.q(t);
                    row.Cells.Add(columnValue);
                }
                if (settings.dq0_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.dq0;
                    row.Cells.Add(columnValue);
                }
                if (settings.c_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.c;
                    row.Cells.Add(columnValue);
                }
                if (settings.w_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.w;
                    row.Cells.Add(columnValue);
                }
                if (settings.E_Check)
                {
                    DataGridViewCell columnValue = new DataGridViewTextBoxCell();
                    columnValue.Value = phisics.E;
                    row.Cells.Add(columnValue);
                }

                dataTable.Add(row);
            }

            return dataTable;
        }
    }
}
