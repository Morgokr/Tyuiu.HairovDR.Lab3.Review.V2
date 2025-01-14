﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.HairovDR.Lab3.Review
{
    public interface IPage
    {

        private void Render()
        {
            throw new NotImplementedException();
        }
        public void UpButtonPressed();

        public void DownButtonPressed();
        public IPage F1ButtonPressed();
        public IPage EscButtonPressed();

        public void NumberPressed(int value);
        public IPage EnterButtonPressed();

    }
}
