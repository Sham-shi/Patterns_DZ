using Patterns_DZ.DZ_24_03_25.Bridge.Languages;
using Patterns_DZ.DZ_24_03_25.Bridge.Programmers;
using Patterns_DZ.DZ_24_03_25.Flyweight;

double longitude = 34.21;
double latitude = 13.44;

var houseFactory = new HouseFactory();

House panelHouse = houseFactory.GetHouse("Panel");
panelHouse.Build(latitude, longitude);

longitude += 0.1;
latitude += 0.1;

House brickHouse = houseFactory.GetHouse("Brick");
brickHouse.Build(latitude, longitude);



var freelancerProgrammer = new FreelancerProgrammer(new CPPLanguage());

freelancerProgrammer.DoWOrk();
freelancerProgrammer.EarnMoney();

var corporateProgrammer = new CorporateProgrammer(new CSharpLanguage());

corporateProgrammer.DoWOrk();
corporateProgrammer.EarnMoney();

freelancerProgrammer.Language = new CSharpLanguage();

freelancerProgrammer.DoWOrk();
freelancerProgrammer.EarnMoney();