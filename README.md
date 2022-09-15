# SplashWindow
 Окно загрузки WPF

<p>var mainWindow = new MainWindow();</p><br> // инициализация главного окна должна происходить вне блока SplashWindow.

<p>using (var loadingVisualiser = new SplashWindow("loading..."))</p>
<p>{</p>
<p>...........</p>
<p>}</p>
