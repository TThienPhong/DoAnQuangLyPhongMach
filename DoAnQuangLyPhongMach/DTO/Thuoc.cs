﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DTO
{
    public class Thuoc
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public DonViTinh DoViTinh { get; set; }
        public int Gia { get; set; }
        public string GhiChu { get; set; }
        public bool Xoa { get; set; }
    }
}
