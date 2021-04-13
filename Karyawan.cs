using System;


namespace ResponsiPemograman3403
{
    class Karyawan
    {
        public string nik, nama;
        public double gaji;
        public Karyawan(string Nik, String Nama, double Gaji)
        {
            nik = Nik;
            nama = Nama;
            if (Gaji <= 0 )
            {
                gaji = 0;
            }
            else {
                gaji = Gaji;
            }
        }
        public void NaikGaji() 
        {
            gaji = (gaji+0.0) + (gaji * (10.0/100.0));
        }

        
    }
}
