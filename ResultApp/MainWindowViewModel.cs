using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ResultApp
{
    public class MainWindowViewModel : ViewModelBase
    {

        private RelayCommand _testCmd;
        public RelayCommand TestCmd => _testCmd ?? (_testCmd = new RelayCommand(
            () => test(),
            () => { return 1 == 1; },
            keepTargetAlive: true
            ));
        private void test()
        {
            LogResult<string> lr = LogResult<string>.Ok("pippo");

            Result<double, string> tr = Result<double, string>.Ok("pluto", 2);

            Result<int> ir = Result<int>.Ok(1, "uno");

            Result r = Result.Ok();

            //LogResult<string> lr = LogResult<string>.Ok("pippo");

            //Result<double, string> tr = Result<double, string>.Ok("pluto", 2);

            //Result<int> ir = Result<int>.Ok(1, "uno");

            //Result r = Result.Ok();


        }

    }
}
