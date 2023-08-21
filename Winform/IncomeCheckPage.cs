using Microsoft.EntityFrameworkCore;
using ScottPlot;
using ScottPlot.Plottable;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class IncomeCheckPage : Form
    {
        private BookingRepository _booking;
        private BookingDetailRepository _bookingDetail;
        private HotelRepository _hotel;
        public IncomeCheckPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IncomeCheckPage_Load(object sender, EventArgs e)
        {
            _booking = new BookingRepository();
            _bookingDetail = new BookingDetailRepository();
            _hotel = new HotelRepository();

            List<Hotel> entityList = _hotel.GetAll().ToList();

            // Add "All" option to the list
            entityList.Insert(0, new Hotel { Id = 0, Name = "All" });

            dataGridView1.DataSource = _booking.GetAll().ToList();

            comboBox1.DataSource = entityList;

            comboBox1.DisplayMember = "Name";

            comboBox1.ValueMember = "Id";



            comboBox2.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingData();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingData();
        }

        public void BindingData()
        {
            var data = _booking.GetAll().ToList();

            if (comboBox1.SelectedIndex != 0)
            {
                int HotelId = Convert.ToInt32(comboBox1.SelectedValue.ToString());

                data = _booking.GetAll().Where(h => h.Hotelid == HotelId).ToList();
            }
            else
            {
                data = _booking.GetAll().ToList();
            }

            switch (comboBox2.SelectedIndex)
            {
                case 2:
                    data = data.OrderBy(d => d.Bookingdate).ToList();
                    break;
                case 3:
                    data = data.OrderBy(d => d.Totalprice).ToList();
                    break;
                case 4:
                    data = data.OrderBy(d => d.Hotelid).ToList();
                    break;
            }

            formsPlot1.Refresh();

            List<Bar> bars = new();

            for (int i = 0; i<data.Count(); i++)
            {
                bars.Add(new Bar
                {
                    Value = data[i].Totalprice,
                    Label = data[i].Bookingdate.ToString(),
                    FillColor = Palette.Category10.GetColor(1),
                    Position = i
                });
            }
            formsPlot1.Plot.AddBarSeries(bars);
            formsPlot1.Plot.Style(Style.Seaborn);
            formsPlot1.Plot.SetAxisLimitsY(0, 100000);

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
