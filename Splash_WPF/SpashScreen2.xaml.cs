using System;
using System.Windows;
using System.Windows.Media; // Necesario para ScaleTransform y GradientBrush
using System.Windows.Shapes; // Necesario para Rectangle
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Splash_WPF
{
    public partial class SpashScreen2 : Page
    {
        public SpashScreen2()
        {
            InitializeComponent();

            // Animación para el logo (zoom)
            var zoomInAnimation = new DoubleAnimation
            {
                From = 0,   // Empezamos el logo pequeño (casi invisible)
                To = 1,     // El logo se hace grande y centrado
                Duration = TimeSpan.FromSeconds(1)  // Duración de la animación
            };
            LogoZoomTransform.BeginAnimation(ScaleTransform.ScaleXProperty, zoomInAnimation);
            LogoZoomTransform.BeginAnimation(ScaleTransform.ScaleYProperty, zoomInAnimation);

            // Animación de las olas en la parte superior
            var topWaveAnimation = new DoubleAnimation
            {
                From = 0,  // Inicia en la posición 0
                To = 20,   // Se mueve un poco hacia abajo
                Duration = TimeSpan.FromSeconds(2), // Lento
                RepeatBehavior = RepeatBehavior.Forever   // Repite infinitamente
            };
            TopWaveRectangle.BeginAnimation(Rectangle.HeightProperty, topWaveAnimation);

            // Animación de las olas en la parte inferior
            var bottomWaveAnimation = new DoubleAnimation
            {
                From = 0,  // Inicia en la posición 0
                To = -20,  // Se mueve un poco hacia arriba
                Duration = TimeSpan.FromSeconds(2), // Lento
                RepeatBehavior = RepeatBehavior.Forever   // Repite infinitamente
            };
            BottomWaveRectangle.BeginAnimation(Rectangle.HeightProperty, bottomWaveAnimation);

            // Temporizador para abrir el formulario de login después de 3 segundos
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);  // 5 segundos (ajustado para ver mejor las animaciones)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Aquí puedes colocar código para abrir el formulario de login o la siguiente pantalla
            Application.Current.Shutdown();  // Cierra la aplicación WPF (si quieres cerrar el Splash)
        }
    }
}
