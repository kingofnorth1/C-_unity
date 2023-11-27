using System;
namespace jicheng{
    class parent{
        public int Width;
        public int Height;
        public void setWidth(int w){
            this.Width = w;
        }
        public void setHeight(int h){
            this.Height = h;
        }
    }
    class childer :parent{
        public int GetArea(){
            return Width*Height;
        }
    }
}