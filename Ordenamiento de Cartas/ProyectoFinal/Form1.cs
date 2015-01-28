using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private bool isDragging = false;
        private void CorazonesK_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl = sender as Control;
            if (isDragging)
            {
                Point p1 = ctrl.PointToScreen(e.Location);
                Point p2 = ctrl.Parent.PointToClient(p1);
                ctrl.Location = p2;
            }  
        }
        private void CorazonesK_MouseDown(object sender, MouseEventArgs e)
        {            
            isDragging = true;
        }   
        private void CorazonesK_MouseUp(object sender, MouseEventArgs e)
        {            
            isDragging = false;            
        }        
        private void btnDesordenar_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            PictureBox[] cartas = baraja();
            int r1 = r.Next(50,500),r2=r.Next(250,500);
            
            for (int i = 1; i <= 26; i++)
            {
                if (cartas[i].Visible == true)
                {
                    r1 = r.Next(50, 500);
                    r2 = r.Next(250, 500);
                    cartas[i].SetBounds(r1, r2, CorazonesK.Width, CorazonesK.Height);
                }
                cartas[i].Enabled = true;
               cartas[i].BackColor = Color.White;
            }
            a = -47; b = 12; contvalue = 0; cont = 0;
            btnPreOrdenar.Enabled = true;
            BtnOrdenar.Enabled = false;
            Visor.Text = "";
            
        }              
              
        public PictureBox getPosicionMenor()
        {            
            PictureBox[] cartas = baraja();            
            int i = 1, menor = auxiliar.Location.X, carta = 0;
            for (i = 1; i <= 26; i++)
            {                
                if((cartas[i].Visible==true)&&cartas[i].BackColor!=Color.Black)
                    if (cartas[i].Location.X<menor)
                        {
                            menor = cartas[i].Location.X;
                            carta = i;                            
                        }
            }
            return cartas[carta];
        }
        public PictureBox[] baraja()
        {
            PictureBox[] baraja = new PictureBox[27];
            //Cartas de Corazones
            baraja[0] = auxiliar;//no se pone null xq surge error en el metodo q busca la MENOR posicion
            baraja[1] = CorazonesA;
            baraja[2] = Corazones2;
            baraja[3] = Corazones3;
            baraja[4] = Corazones4;
            baraja[5] = Corazones5;
            baraja[6] = Corazones6;
            baraja[7] = Corazones7;
            baraja[8] = Corazones8;
            baraja[9] = Corazones9;
            baraja[10] = Corazones10;
            baraja[11] = CorazonesJ;
            baraja[12] = CorazonesQ;
            baraja[13] = CorazonesK;

            //Cartas de espadas
            baraja[14] = EspadasA;
            baraja[15] = Espadas2;
            baraja[16] = Espadas3;
            baraja[17] = Espadas4;
            baraja[18] = Espadas5;
            baraja[19] = Espadas6;
            baraja[20] = Espadas7;
            baraja[21] = Espadas8;
            baraja[22] = Espadas9;
            baraja[23] = Espadas10;
            baraja[24] = EspadasJ;
            baraja[25] = EspadasQ;
            baraja[26] = EspadasK;
            return baraja;
        }

        public void inicializar()
        {

        }
        private void numerodeCartas_ValueChanged(object sender, EventArgs e)
        {           
           PictureBox[] cartas = baraja();
           BtnOrdenar.Enabled = false;
           btnPreOrdenar.Enabled = false;
           switch (Convert.ToInt32(numerodeCartas.Value))
            {
                case 2:
                    for (int i = 3; i <= 26; i++)
                        cartas[i].Visible = false;
                    break;
                case 3:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 3)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 4:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 4)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 5:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 5)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 6:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 6)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 7:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 7)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 8:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 8)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 9:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 9)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 10:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 10)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 11:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 11)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 12:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 12)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                
                case 13:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 13)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 14:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 14)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 15:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 15)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 16:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 16)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 17:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 17)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 18:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 18)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 19:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 19)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 20:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 20)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 21:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 21)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 22:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 22)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 23:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 23)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 24:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 24)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 25:
                    for (int i = 3; i <= 26; i++)
                        if (i <= 25)
                            cartas[i].Visible = true;
                        else
                            cartas[i].Visible = false;
                    break;
                case 26:
                    for (int i = 3; i <= 26; i++)
                        cartas[i].Visible = true;
                    break;
            }               
        }
        int cont = 0,contvalue=0;       
        int a = -47, b = 12;//puntos inicial de la 1ra carta, a=-47 xq se sumara antes de posicionar la carta en su nuevo sitio.
        Boolean bandera = false;
        private void btnPreOrdenar_Click(object sender, EventArgs e)
        {
            BtnOrdenar.Enabled = true;
            bandera = true;
            timer1.Enabled = true;
        }        
        public PictureBox localizarCarta(int x, int y)
        {
            PictureBox carta=null;
            PictureBox[] cartas = baraja();
            for (int i = 1; i < baraja().Length; i++)
            {
                if (cartas[i].Location.X == x && cartas[i].Location.Y==y)
                    return cartas[i];
            }
                return carta;
        }
        int[] posicionx;
        int[] posiciony;        
        public int[] getArregloParaOrdenar()
        {
            int[] arr = new int[Convert.ToInt32(numerodeCartas.Value)+1];           
            int x = 12, y = 12,cont=0;
            posicionx = new int[Convert.ToInt32(numerodeCartas.Value)+1];
            posiciony = new int[Convert.ToInt32(numerodeCartas.Value)+1];
            for (int i = 1; i <=numerodeCartas.Value; i++)
            {
                if (cont == 13)
                {
                    x = 12;
                    y = y + 94;
                    arr[i] = Convert.ToInt32(localizarCarta(x, y).Tag);
                    posicionx[i] = x;
                    posiciony[i] = y;
                    cont = 0;
                    x = x + 59;
                }
                else
                {                    
                    arr[i] = Convert.ToInt32(localizarCarta(x, y).Tag);
                    posicionx[i] = x;
                    posiciony[i] = y;
                    x = x + 59;
                }
                cont++;
            }
            for (int k = 1; k < arr.Length; k++)
                Visor.Text = Visor.Text + arr[k] + " ";
            Visor.Text = Visor.Text + "\r\n";
            return arr;
        }
        public void seleccion(int sel)
        {
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {
                if (sel == Convert.ToInt32(baraja()[i].Tag))
                {                    
                    baraja()[i].BackColor = Color.Fuchsia;
                }
            }
        }
        public void mover(int cambiar1, int cambiar2)
        {
            int[] auxiliar = ordenado;
            int xpos1=0, ypos1=0, xpos2=0, ypos2=0;
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {                
                if (cambiar2 == Convert.ToInt32(baraja()[i].Tag))
                {
                     for (int j= 1; j <= numerodeCartas.Value; j++)
                         if (cambiar2 == auxiliar[j])
                         {
                             xpos1 = posicionx[j];
                             ypos1 = posiciony[j];
                             
                         }
                }
            }
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {                
                if (cambiar1 == Convert.ToInt32(baraja()[i].Tag))
                {
                    for (int j = 1; j <= numerodeCartas.Value; j++)
                        if (cambiar1 == auxiliar[j])
                        {
                            xpos2 = posicionx[j];
                            ypos2 = posiciony[j];
                        }
                }
            }
            
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {                
                if (cambiar1 == Convert.ToInt32(baraja()[i].Tag))
                {
                    movecarta(xpos2,ypos2,baraja()[i]);
                }
            }
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {
                if (cambiar2 == Convert.ToInt32(baraja()[i].Tag))
                {
                    movecarta(xpos1, ypos1, baraja()[i]);
                }
            }
        }

        public void QuicSORT(int[] a)
        {
            
                QuickSORT(1, a.Length - 1, a);
                
        }        
        public void QuickSORT(int ini, int fin, int[] a)
        {
            
            {
                int left = ini;
                int right = fin;
                int mid = a[(ini + fin) / 2];             
                
                
                
                    do
                    {
                        while (a[left] < mid)
                            left++;
                        while (a[right] > mid)
                            right--;

                        if (left <= right)
                        {
                            seleccion(mid);
                            for (int j = ((ini + fin) / 2) + 1; j <= fin; j++)
                                temporal(a[j]);
                            for (int j = ini; j < (ini + fin) / 2; j++)
                                temporal2(a[j]);
                            int t = a[left];
                            
                            a[left] = a[right];
                            
                            
                            a[right] = t;
                            for (int i = 1; i < a.Length; i++)
                            {
                                Visor.Text = Visor.Text + a[i] + " ";
                            }
                            Visor.Text = Visor.Text + "\r\n";
                            mover(a[right],a[left]);
                            mover(a[left], a[right]);
                            
                            Thread.Sleep(2000);
                           
                            left++;
                            right--;                          
                            
                        }
                        restablecerBackColor();
                    } while (left <= right);
                    
                    if (left < fin)
                        QuickSORT(left, fin, a);
                    if (right > ini)
                        QuickSORT(ini, right, a);
                    restablecerBackColor();
            }
        }
        public void restablecerBackColor()
        {
            for (int i = 1; i <= numerodeCartas.Value; i++)
                baraja()[i].BackColor = Color.White;
        }
        
        private void movecarta(int x,int y,PictureBox carta)
        {
                Refresh();//vuelve a dibujar 
                if (x < carta.Location.X && y < carta.Location.Y)
                {
                    do
                    {
                        carta.Top -= 1;
                    } while (carta.Top > y);
                    do
                    {
                        carta.Left -= 1;
                    } while (carta.Left > x);
                }
                else if (x > carta.Location.X && y < carta.Location.Y)
                {
                    do
                    {
                        carta.Top -= 1;
                    } while (carta.Top > y);
                    do
                    {
                        carta.Left += 1;
                    } while (carta.Left < x);
                }
                else if (x > carta.Location.X && y < carta.Location.Y)
                {
                    do
                    {
                        carta.Top += 1;
                    } while (carta.Top < y);
                    do
                    {
                        carta.Left += 1;
                    } while (carta.Left < x);
                }
                else if (x < carta.Location.X && y > carta.Location.Y)
                {
                    do
                    {
                        carta.Top += 1;
                    } while (carta.Top < y);
                    do
                    {
                        carta.Left -= 1;
                    } while (carta.Left > x);
                }
                else
                {
                    do
                    {
                        carta.Top -= 2;

                    } while (carta.Top > y);
                    do
                    {
                        carta.Left += 2;

                    } while (carta.Left < x);
                    bandera = false;
                }
                Refresh();           
        }
        int contaux = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            do
            {
            PictureBox cartaMenorPos;
            cartaMenorPos = getPosicionMenor();
            int x = 0, y = 0;
            
            x = cartaMenorPos.Location.X;
            y = cartaMenorPos.Location.Y;
           
            cartaMenorPos.BackColor = Color.Black;
            cartaMenorPos.Enabled = false;
            contvalue++;
            cont++;
            if (cont <= 13)
            {               
                a = a + 59;
                movecarta( a, b, cartaMenorPos);        
            }
            else
            {
                
                a = 12;
                b = b + 94;
                movecarta(a, b, cartaMenorPos);
                
                
                cont = 0;
            }
            if ((contvalue == numerodeCartas.Value || cont == numerodeCartas.Value))
            {
                btnPreOrdenar.Enabled = false;
                for (int i = 1; i <= numerodeCartas.Value; i++)
                    baraja()[i].BackColor = Color.White;
                ordenado = getArregloParaOrdenar();
            }
                contaux++;
            }while(contaux<numerodeCartas.Value);
            timer1.Enabled = false;
            contaux = 0;
        }
        int[] ordenado;
       
        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            bandera = true;
            if (cbMetodo.Text == "Quick-Sort")
            {
                QuicSORT(ordenado);                
            }
            else if (cbMetodo.Text == "Shaker-Sort")
                shaker(ordenado, ordenado.Length);
            else
                MessageBox.Show("Error:\nSeleccione un método de ordenamiento", "Ventana de errores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        public void temporal(int aux)
        {
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {
                if (aux == Convert.ToInt32(baraja()[i].Tag))
                {
                    baraja()[i].BackColor = Color.Gold;
                }
            }
        }
        public void temporal2(int aux)
        {
            for (int i = 1; i <= numerodeCartas.Value; i++)
            {
                if (aux == Convert.ToInt32(baraja()[i].Tag))
                {
                    baraja()[i].BackColor = Color.Aqua;
                }
            }
        }
        public int[] shaker(int[] A, int n)
        {

            int fin, ini, aux, m = -1;//Crear variables          
                
                do
                {
                    ini = A[n - 1];//inicia con el número en la penúltima posicion 
                    
                    for (int i = n - 1; i > m; i--)// empieza con la penúltima posición y recorre hasta -1 en decremento
                    {
                       if (bandera == true)
                        {
                        if (ini < A[i])//si el inicio, es decir la penúltima posición
                        {
                           
                           // mover(aux, A[i]);
                          
                                seleccion(A[i]);
                                seleccion(A[i+1]);
                                aux = A[i];
                                //mover(A[i], ini);
                                A[i] = ini;
                                //mover(A[i], ini);
                                //mover(A[i + 1], aux);
                                A[i + 1] = aux;
                                //mover(ini, A[i]);
                                ini = A[i];
                                
                                //mover(ini, A[i]);
                                for (int k = 1; k < A.Length; k++)
                                    Visor.Text = Visor.Text + A[k] + " ";
                                Visor.Text = Visor.Text + "\r\n";
                                mover(A[i], A[i + 1]);
                                mover(A[i+1],A[i]);
                                restablecerBackColor();
                            }
                            else
                            {
                                ini = A[i];
                            }
                        
                        }
                        
                    }
                    if (numerodeCartas.Value != 2)
                    {
                        m = m + 1;
                        fin = A[m + 1];//en fin almanecamos la primera posición

                        for (int i = m + 1; i < n; i++)//comienza desde la segunda posición hasta la longitud del arreglo en incremento
                        {
                            if (bandera == true)
                            {
                                if (fin > A[i])//compara si fin es mayor que cada posición
                                {


                                    temporal(A[i]);
                                    temporal(A[i - 1]);
                                    aux = A[i];
                                    A[i - 1] = aux;
                                    A[i] = fin;
                                    fin = A[i];
                                    for (int k = 1; k < A.Length; k++)
                                        Visor.Text = Visor.Text + A[k] + " ";
                                    Visor.Text = Visor.Text + "\r\n";
                                    mover(A[i], A[i - 1]);
                                    mover(A[i - 1], A[i]);
                                    restablecerBackColor();
                                }
                                else
                                {
                                    fin = A[i];
                                }
                            }
                        }


                        n = n - 1;//decrece n
                    }
                } while (m != 2 && n != 3);
            return A;
        }
        
    }
}
