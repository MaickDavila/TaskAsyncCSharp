# ProgressBar en segundo plano
Dependencias 

- using System;
- using System.Threading;
- using System.Threading.Tasks;
- using System.Windows.Forms;


```
IProgress<int> progress = new Progress<int>(item => {
                progressbar.Value = item;
                label.Text = $"{item}%";
});


Task.Run(() => {

  for (int i = 0; i < 100; i++)
  {
    progress.Report(i);
    Thread.Sleep(70);
  }
  progress.Report(100);
});
```
