using System;


namespace ResponsiPemograman3403
{
    class Karyawan
    {
        public string nik, nama;
        public double gaji;
        public Karyawan(string Nik, String Nama, double Gaji)
        {
            this.nik = Nik;
            this.nama = Nama;
            this.gaji = Gaji;
            if (Gaji <= 0)
                this.gaji = 0;
        }
        public void NaikGaji() 
        {
            this.gaji = (this.gaji+0.0) + (this.gaji * (10.0/100.0));
        }

        
    }
}
