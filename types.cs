using System;

namespace PokemonType
{
    class types
    {
        public static void main()
        {
            string seperator = new string('=', 90);
            Console.WriteLine(seperator);
            Console.Write("Enter the types: ");
            string type = Console.ReadLine();
            Console.WriteLine(seperator + '\n');

            switch(type)
            {
                case "normal":
                    normalType.normal();
                    break;
                case "normal fighting":
                    normalType.normalFighting();
                    break;
                case "normal flying":
                    normalType.normalFlying();
                    break;
                case "normal poison":
                    normalType.normalPoison();
                    break;
                case "normal ground":
                    normalType.normalGround();
                    break;
                case "normal rock":
                    normalType.normalRock();
                    break;
                case "normal bug":
                    normalType.normalBug();
                    break;
                case "normal ghost":
                    normalType.normalGhost();
                    break;
                case "normal steel":
                    normalType.normalSteel();
                    break;
                case "normal fire":
                    normalType.normalFire();
                    break;
                case "normal water":
                    normalType.normalWater();
                    break;
                case "normal grass":
                    normalType.normalGrass();
                    break;
                case "normal electric":
                    normalType.normalElectric();
                    break;
                case "normal psychic":
                    normalType.normalPsychic();
                    break;
                case "normal ice":
                    normalType.normalIce();
                    break;
                case "normal dragon":
                    normalType.normalDragon();
                    break;
                case "normal dark":
                    normalType.normalDark();
                    break;
                case "normal fairy":
                    normalType.normalFairy();
                    break;
                case "fighting":
                    fightingType.fighting();
                    break;
                case "fighting normal":
                    fightingType.fightingNormal();
                    break;
                case "fighting flying":
                    fightingType.fightingFlying();
                    break;
                case "fighting poison":
                    fightingType.fightingPoison();
                    break;
                case "fighting ground":
                    fightingType.fightingGround();
                    break;
                case "fighting rock":
                    fightingType.fightingRock();
                    break;
                case "fighting bug":
                    fightingType.fightingBug();
                    break;
                case "fighting ghost":
                    fightingType.fightingGhost();
                    break;
                case "fighting steel":
                    fightingType.fightingSteel();
                    break;
                case "fighting fire":
                    fightingType.fightingFire();
                    break;
                case "fighting water":
                    fightingType.fightingWater();
                    break;
                case "fighting grass":
                    fightingType.fightingGrass();
                    break;
                case "fighting electric":
                    fightingType.fightingElectric();
                    break;
                case "fighting psychic":
                    fightingType.fightingPsychic();
                    break;
                case "fighting ice":
                    fightingType.fightingIce();
                    break;
                case "fighting dragon":
                    fightingType.fightingDragon();
                    break;
                case "fighting dark":
                    fightingType.fightingDark();
                    break;
                case "fighting fairy":
                    fightingType.fightingFairy();
                    break;
                case "flying":
                    flyingType.flying();
                    break;
                case "flying normal":
                    flyingType.flyingNormal();
                    break;
                case "flying fighting":
                    flyingType.flyingFighting();
                    break;
                case "flying poison":
                    flyingType.flyingPoison();
                    break;
                case "flying ground":
                    flyingType.flyingGround();
                    break;
                case "flying rock":
                    flyingType.flyingRock();
                    break;
                case "flying bug":
                    flyingType.flyingBug();
                    break;
                case "flying ghost":
                    flyingType.flyingGhost();
                    break;
                case "flying steel":
                    flyingType.flyingSteel();
                    break;
                case "flying fire":
                    flyingType.flyingFire();
                    break;
                case "flying water":
                    flyingType.flyingWater();
                    break;
                case "flying grass":
                    flyingType.flyingGrass();
                    break;
                case "flying electric":
                    flyingType.flyingElectric();
                    break;
                case "flying psychic":
                    flyingType.flyingPsychic();
                    break;
                case "flying ice":
                    flyingType.flyingIce();
                    break;
                case "flying dragon":
                    flyingType.flyingDragon();
                    break;
                case "flying dark":
                    flyingType.flyingDark();
                    break;
                case "flying fairy":
                    flyingType.flyingFairy();
                    break;
                case "poison":
                    poisonType.poison();
                    break;
                case "poison normal":
                    poisonType.poisonNormal();
                    break;
                case "poison fighting":
                    poisonType.poisonFighting();
                    break;
                case "poison flying":
                    poisonType.poisonFlying();
                    break;
                case "poison ground":
                    poisonType.poisonGround();
                    break;
                case "poison rock":
                    poisonType.poisonRock();
                    break;
                case "poison bug":
                    poisonType.poisonBug();
                    break;
                case "poison ghost":
                    poisonType.poisonGhost();
                    break;
                case "poison steel":
                    poisonType.poisonSteel();
                    break;
                case "poison fire":
                    poisonType.poisonFire();
                    break;
                case "poison water":
                    poisonType.poisonWater();
                    break;
                case "poison grass":
                    poisonType.poisonGrass();
                    break;
                case "poison electric":
                    poisonType.poisonElectric();
                    break;
                case "poison psychic":
                    poisonType.poisonPsychic();
                    break;
                case "poison ice":
                    poisonType.poisonIce();
                    break;
                case "poison dragon":
                    poisonType.poisonDragon();
                    break;
                case "poison dark":
                    poisonType.poisonDark();
                    break;
                case "poison fairy":
                    poisonType.poisonFairy();
                    break;
                case "ground":
                    groundType.ground();
                    break;
                case "ground normal":
                    groundType.groundNormal();
                    break;
                case "ground fighting":
                    groundType.groundFighting();
                    break;
                case "ground flying":
                    groundType.groundFlying();
                    break;
                case "ground poison":
                    groundType.groundPoison();
                    break;
                case "ground rock":
                    groundType.groundRock();
                    break;
                case "ground bug":
                    groundType.groundBug();
                    break;
                case "ground ghost":
                    groundType.groundGhost();
                    break;
                case "ground steel":
                    groundType.groundSteel();
                    break;
                case "ground fire":
                    groundType.groundFire();
                    break;
                case "ground water":
                    groundType.groundWater();
                    break;
                case "ground grass":
                    groundType.groundGrass();
                    break;
                case "ground electric":
                    groundType.groundElectric();
                    break;
                case "ground psychic":
                    groundType.groundPsychic();
                    break;
                case "ground ice":
                    groundType.groundIce();
                    break;
                case "ground dragon":
                    groundType.groundDragon();
                    break;
                case "ground dark":
                    groundType.groundDark();
                    break;
                case "ground fairy":
                    groundType.groundFairy();
                    break;
                case "rock":
                    rockType.rock();
                    break;
                case "rock normal":
                    rockType.rockNormal();
                    break;
                case "rock fighting":
                    rockType.rockFighting();
                    break;
                case "rock flying":
                    rockType.rockFlying();
                    break;
                case "rock poison":
                    rockType.rockPoison();
                    break;
                case "rock ground":
                    rockType.rockGround();
                    break;
                case "rock bug":
                    rockType.rockBug();
                    break;
                case "rock ghost":
                    rockType.rockGhost();
                    break;
                case "rock steel":
                    rockType.rockSteel();
                    break;
                case "rock fire":
                    rockType.rockFire();
                    break;
                case "rock water":
                    rockType.rockWater();
                    break;
                case "rock grass":
                    rockType.rockGrass();
                    break;
                case "rock electric":
                    rockType.rockElectric();
                    break;
                case "rock psychic":
                    rockType.rockPsychic();
                    break;
                case "rock ice":
                    rockType.rockIce();
                    break;
                case "rock dragon":
                    rockType.rockDragon();
                    break;
                case "rock dark":
                    rockType.rockDark();
                    break;
                case "rock fairy":
                    rockType.rockFairy();
                    break;
                case "bug":
                    bugType.bug();
                    break;
                case "bug normal":
                    bugType.bugNormal();
                    break;
                case "bug fighting":
                    bugType.bugFighting();
                    break;
                case "bug flying":
                    bugType.bugFlying();
                    break;
                case "bug poison":
                    bugType.bugPoison();
                    break;
                case "bug ground":
                    bugType.bugGround();
                    break;
                case "bug rock":
                    bugType.bugRock();
                    break;
                case "bug ghost":
                    bugType.bugGhost();
                    break;
                case "bug steel":
                    bugType.bugSteel();
                    break;
                case "bug fire":
                    bugType.bugFire();
                    break;
                case "bug water":
                    bugType.bugWater();
                    break;
                case "bug grass":
                    bugType.bugGrass();
                    break;
                case "bug electric":
                    bugType.bugElectric();
                    break;
                case "bug psychic":
                    bugType.bugPsychic();
                    break;
                case "bug ice":
                    bugType.bugIce();
                    break;
                case "bug dragon":
                    bugType.bugDragon();
                    break;
                case "bug dark":
                    bugType.bugDark();
                    break;
                case "bug fairy":
                    bugType.bugFairy();
                    break;
                case "ghost":
                    ghostType.ghost();
                    break;
                case "ghost normal":
                    ghostType.ghostNormal();
                    break;
                case "ghost fighting":
                    ghostType.ghostFighting();
                    break;
                case "ghost flying":
                    ghostType.ghostFlying();
                    break;
                case "ghost poison":
                    ghostType.ghostPoison();
                    break;
                case "ghost ground":
                    ghostType.ghostGround();
                    break;
                case "ghost rock":
                    ghostType.ghostRock();
                    break;
                case "ghost bug":
                    ghostType.ghostBug();
                    break;
                case "ghost steel":
                    ghostType.ghostSteel();
                    break;
                case "ghost fire":
                    ghostType.ghostFire();
                    break;
                case "ghost water":
                    ghostType.ghostWater();
                    break;
                case "ghost grass":
                    ghostType.ghostGrass();
                    break;
                case "ghost electric":
                    ghostType.ghostElectric();
                    break;
                case "ghost psychic":
                    ghostType.ghostPsychic();
                    break;
                case "ghost ice":
                    ghostType.ghostIce();
                    break;
                case "ghost dragon":
                    ghostType.ghostDragon();
                    break;
                case "ghost dark":
                    ghostType.ghostDark();
                    break;
                case "ghost fairy":
                    ghostType.ghostFairy();
                    break;
                case "steel":
                    steelType.steel();
                    break;
                case "steel normal":
                    steelType.steelNormal();
                    break;
                case "steel fighting":
                    steelType.steelFighting();
                    break;
                case "steel flying":
                    steelType.steelFlying();
                    break;
                case "steel poison":
                    steelType.steelPoison();
                    break;
                case "steel ground":
                    steelType.steelGround();
                    break;
                case "steel rock":
                    steelType.steelRock();
                    break;
                case "steel bug":
                    steelType.steelBug();
                    break;
                case "steel ghost":
                    steelType.steelGhost();
                    break;
                case "steel fire":
                    steelType.steelFire();
                    break;
                case "steel water":
                    steelType.steelWater();
                    break;
                case "steel grass":
                    steelType.steelGrass();
                    break;
                case "steel electric":
                    steelType.steelElectric();
                    break;
                case "steel psychic":
                    steelType.steelPsychic();
                    break;
                case "steel ice":
                    steelType.steelIce();
                    break;
                case "steel dragon":
                    steelType.steelDragon();
                    break;
                case "steel dark":
                    steelType.steelDark();
                    break;
                case "steel fairy":
                    steelType.steelFairy();
                    break;
                case "fire":
                    fireType.fire();
                    break;
                case "fire normal":
                    fireType.fireNormal();
                    break;
                case "fire fighting":
                    fireType.fireFighting();
                    break;
                case "fire flying":
                    fireType.fireFlying();
                    break;
                case "fire poison":
                    fireType.firePoison();
                    break;
                case "fire ground":
                    fireType.fireGround();
                    break;
                case "fire rock":
                    fireType.fireRock();
                    break;
                case "fire bug":
                    fireType.fireBug();
                    break;
                case "fire ghost":
                    fireType.fireGhost();
                    break;
                case "fire steel":
                    fireType.fireSteel();
                    break;
                case "fire water":
                    fireType.fireWater();
                    break;
                case "fire grass":
                    fireType.fireGrass();
                    break;
                case "fire electric":
                    fireType.fireElectric();
                    break;
                case "fire psychic":
                    fireType.firePsychic();
                    break;
                case "fire ice":
                    fireType.fireIce();
                    break;
                case "fire dragon":
                    fireType.fireDragon();
                    break;
                case "fire dark":
                    fireType.fireDark();
                    break;
                case "fire fairy":
                    fireType.fireFairy();
                    break;
                case "water":
                    waterType.water();
                    break;
                case "water normal":
                    waterType.waterNormal();
                    break;
                case "water fighting":
                    waterType.waterFighting();
                    break;
                case "water flying":
                    waterType.waterFlying();
                    break;
                case "water poison":
                    waterType.waterPoison();
                    break;
                case "water ground":
                    waterType.waterGround();
                    break;
                case "water rock":
                    waterType.waterRock();
                    break;
                case "water bug":
                    waterType.waterBug();
                    break;
                case "water ghost":
                    waterType.waterGhost();
                    break;
                case "water steel":
                    waterType.waterSteel();
                    break;
                case "water fire":
                    waterType.waterFire();
                    break;
                case "water grass":
                    waterType.waterGrass();
                    break;
                case "water electric":
                    waterType.waterElectric();
                    break;
                case "water psychic":
                    waterType.waterPsychic();
                    break;
                case "water ice":
                    waterType.waterIce();
                    break;
                case "water dragon":
                    waterType.waterDragon();
                    break;
                case "water dark":
                    waterType.waterDark();
                    break;
                case "water fairy":
                    waterType.waterFairy();
                    break;
                case "grass":
                    grassType.grass();
                    break;
                case "grass normal":
                    grassType.grassNormal();
                    break;
                case "grass fighting":
                    grassType.grassFighting();
                    break;
                case "grass flying":
                    grassType.grassFlying();
                    break;
                case "grass poison":
                    grassType.grassPoison();
                    break;
                case "grass ground":
                    grassType.grassGround();
                    break;
                case "grass rock":
                    grassType.grassRock();
                    break;
                case "grass bug":
                    grassType.grassBug();
                    break;
                case "grass ghost":
                    grassType.grassGhost();
                    break;
                case "grass steel":
                    grassType.grassSteel();
                    break;
                case "grass fire":
                    grassType.grassFire();
                    break;
                case "grass water":
                    grassType.grassWater();
                    break;
                case "grass electric":
                    grassType.grassElectric();
                    break;
                case "grass psychic":
                    grassType.grassPsychic();
                    break;
                case "grass ice":
                    grassType.grassIce();
                    break;
                case "grass dragon":
                    grassType.grassDragon();
                    break;
                case "grass dark":
                    grassType.grassDark();
                    break;
                case "grass fairy":
                    grassType.grassFairy();
                    break;
                case "electric":
                    electricType.electric();
                    break;
                case "electric normal":
                    electricType.electricNormal();
                    break;
                case "electric fighting":
                    electricType.electricFighting();
                    break;
                case "electric flying":
                    electricType.electricFlying();
                    break;
                case "electric poison":
                    electricType.electricPoison();
                    break;
                case "electric ground":
                    electricType.electricGround();
                    break;
                case "electric rock":
                    electricType.electricRock();
                    break;
                case "electric bug":
                    electricType.electricBug();
                    break;
                case "electric ghost":
                    electricType.electricGhost();
                    break;
                case "electric steel":
                    electricType.electricSteel();
                    break;
                case "electric fire":
                    electricType.electricFire();
                    break;
                case "electric water":
                    electricType.electricWater();
                    break;
                case "electric grass":
                    electricType.electricGrass();
                    break;
                case "electric psychic":
                    electricType.electricPsychic();
                    break;
                case "electric ice":
                    electricType.electricIce();
                    break;
                case "electric dragon":
                    electricType.electricDragon();
                    break;
                case "electric dark":
                    electricType.electricDark();
                    break;
                case "electric fairy":
                    electricType.electricFairy();
                    break;
                case "psychic":
                    psychicType.psychic();
                    break;
                case "psychic normal":
                    psychicType.psychicNormal();
                    break;
                case "psychic fighting":
                    psychicType.psychicFighting();
                    break;
                case "psychic flying":
                    psychicType.psychicFlying();
                    break;
                case "psychic poison":
                    psychicType.psychicPoison();
                    break;
                case "psychic ground":
                    psychicType.psychicGround();
                    break;
                case "psychic rock":
                    psychicType.psychicRock();
                    break;
                case "psychic bug":
                    psychicType.psychicBug();
                    break;
                case "psychic ghost":
                    psychicType.psychicGhost();
                    break;
                case "psychic steel":
                    psychicType.psychicSteel();
                    break;
                case "psychic fire":
                    psychicType.psychicFire();
                    break;
                case "psychic water":
                    psychicType.psychicWater();
                    break;
                case "psychic grass":
                    psychicType.psychicGrass();
                    break;
                case "psychic electric":
                    psychicType.psychicElectric();
                    break;
                case "psychic ice":
                    psychicType.psychicIce();
                    break;
                case "psychic dragon":
                    psychicType.psychicDragon();
                    break;
                case "psychic dark":
                    psychicType.psychicDark();
                    break;
                case "psychic fairy":
                    psychicType.psychicFairy();
                    break;
                case "ice":
                    iceType.ice();
                    break;
                case "ice normal":
                    iceType.iceNormal();
                    break;
                case "ice fighting":
                    iceType.iceFighting();
                    break;
                case "ice flying":
                    iceType.iceFlying();
                    break;
                case "ice poison":
                    iceType.icePoison();
                    break;
                case "ice ground":
                    iceType.iceGround();
                    break;
                case "ice rock":
                    iceType.iceRock();
                    break;
                case "ice bug":
                    iceType.iceBug();
                    break;
                case "ice ghost":
                    iceType.iceGhost();
                    break;
                case "ice steel":
                    iceType.iceSteel();
                    break;
                case "ice fire":
                    iceType.iceFire();
                    break;
                case "ice water":
                    iceType.iceWater();
                    break;
                case "ice grass":
                    iceType.iceGrass();
                    break;
                case "ice electric":
                    iceType.iceElectric();
                    break;
                case "ice psychic":
                    iceType.icePsychic();
                    break;
                case "ice dragon":
                    iceType.iceDragon();
                    break;
                case "ice dark":
                    iceType.iceDark();
                    break;
                case "ice fairy":
                    iceType.iceFairy();
                    break;
                case "dragon":
                    dragonType.dragon();
                    break;
                case "dragon normal":
                    dragonType.dragonNormal();
                    break;
                case "dragon fighting":
                    dragonType.dragonFighting();
                    break;
                case "dragon flying":
                    dragonType.dragonFlying();
                    break;
                case "dragon poison":
                    dragonType.dragonPoison();
                    break;
                case "dragon ground":
                    dragonType.dragonGround();
                    break;
                case "dragon rock":
                    dragonType.dragonRock();
                    break;
                case "dragon bug":
                    dragonType.dragonBug();
                    break;
                case "dragon ghost":
                    dragonType.dragonGhost();
                    break;
                case "dragon steel":
                    dragonType.dragonSteel();
                    break;
                case "dragon fire":
                    dragonType.dragonFire();
                    break;
                case "dragon water":
                    dragonType.dragonWater();
                    break;
                case "dragon grass":
                    dragonType.dragonGrass();
                    break;
                case "dragon electric":
                    dragonType.dragonElectric();
                    break;
                case "dragon psychic":
                    dragonType.dragonPsychic();
                    break;
                case "dragon ice":
                    dragonType.dragonIce();
                    break;
                case "dragon dark":
                    dragonType.dragonDark();
                    break;
                case "dragon fairy":
                    dragonType.dragonFairy();
                    break;
                case "dark":
                    darkType.dark();
                    break;
                case "dark normal":
                    darkType.darkNormal();
                    break;
                case "dark fighting":
                    darkType.darkFighting();
                    break;
                case "dark flying":
                    darkType.darkFlying();
                    break;
                case "dark poison":
                    darkType.darkPoison();
                    break;
                case "dark ground":
                    darkType.darkGround();
                    break;
                case "dark rock":
                    darkType.darkRock();
                    break;
                case "dark bug":
                    darkType.darkBug();
                    break;
                case "dark ghost":
                    darkType.darkGhost();
                    break;
                case "dark steel":
                    darkType.darkSteel();
                    break;
                case "dark fire":
                    darkType.darkFire();
                    break;
                case "dark water":
                    darkType.darkWater();
                    break;
                case "dark grass":
                    darkType.darkGrass();
                    break;
                case "dark electric":
                    darkType.darkElectric();
                    break;
                case "dark psychic":
                    darkType.darkPsychic();
                    break;
                case "dark ice":
                    darkType.darkIce();
                    break;
                case "dark dragon":
                    darkType.darkDragon();
                    break;
                case "dark fairy":
                    darkType.darkFairy();
                    break;
                case "fairy":
                    fairyType.fairy();
                    break;
                case "fairy normal":
                    fairyType.fairyNormal();
                    break;
                case "fairy fighting":
                    fairyType.fairyFighting();
                    break;
                case "fairy flying":
                    fairyType.fairyFlying();
                    break;
                case "fairy poison":
                    fairyType.fairyPoison();
                    break;
                case "fairy ground":
                    fairyType.fairyGround();
                    break;
                case "fairy rock":
                    fairyType.fairyRock();
                    break;
                case "fairy bug":
                    fairyType.fairyBug();
                    break;
                case "fairy ghost":
                    fairyType.fairyGhost();
                    break;
                case "fairy steel":
                    fairyType.fairySteel();
                    break;
                case "fairy fire":
                    fairyType.fairyFire();
                    break;
                case "fairy water":
                    fairyType.fairyWater();
                    break;
                case "fairy grass":
                    fairyType.fairyGrass();
                    break;
                case "fairy electric":
                    fairyType.fairyElectric();
                    break;
                case "fairy psychic":
                    fairyType.fairyPsychic();
                    break;
                case "fairy ice":
                    fairyType.fairyIce();
                    break;
                case "fairy dragon":
                    fairyType.fairyDragon();
                    break;
                case "fairy dark":
                    fairyType.fairyDark();
                    break;
                case "exit":
                    Environment.Exit(1);
                    break;
            }

        }

    }
}
