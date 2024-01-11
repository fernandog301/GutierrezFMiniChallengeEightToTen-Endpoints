using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GutierrezFMiniChallengeEightToTen_Endpoints.Services;

    public interface IGuessItService
    {
            public string EasyMode(int number);
            public string MediumMode(int number);
            public string HardMode(int number);


    }