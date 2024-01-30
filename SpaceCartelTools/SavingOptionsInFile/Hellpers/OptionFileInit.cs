using KlikaczBot.SavingOptionsInFile;
using SpaceCartelTools.Buldings;
using SpaceCartelTools.Buldings.Hellpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCartelTools.SavingOptionsInFile.Hellpers
{
    public class OptionFileInit
    {
        public AppOptData Init()
        {

            return new AppOptData()
            {
                PriceIronOre = new Price(2, 2),
                PriceCopperOre = new Price(2, 2),
                PriceUranOre = new Price(2, 2),
                PriceSteel = new Price(6, 6),
                PriceUran = new Price(6, 6),
                PriceCopper = new Price(6, 6),
                PriceRedSeed = new Price(3, 1),
                PriceBlueSeed = new Price(3, 1),
                PriceOrangeSeed = new Price(3, 1),
                PriceRedFlower = new Price(21, 7),
                PriceBlueFlower = new Price(21, 7),
                PriceOrangeFlower = new Price(21, 7),
                PriceRedShip = new Price(10, 10),
                PriceBlueShip = new Price(10, 10),
                PriceOrangeShip = new Price(10, 10),
                
                MineBulding = new Bulding
                {
                    FirstProduct = false,
                    SecProduct = false,
                    ThirdProduct = false,
                    DevelopingCost = new List<(int, int)> { (10, 10), (20, 20), (40, 40) },

                    FirstProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }
                    },
                    SecProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    },ThirdProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    }

                },SteelworksBulding  = new Bulding
                {
                    FirstProduct = false,
                    SecProduct = false,
                    ThirdProduct = false,
                    DevelopingCost = new List<(int, int)> { (10, 10), (20, 20), (40, 40) },

                    FirstProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }
                    },
                    SecProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    },
                    ThirdProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (100, 0),
                                (110, 7),
                                (121, 7),
                                (133, 9),
                                (146, 9),
                                (161, 11),
                                (177, 11),
                                (195, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    }

                },ShipyardBulding  = new Bulding
                {
                    FirstProduct = false,
                    SecProduct = false,
                    ThirdProduct = false,
                    DevelopingCost = new List<(int, int)> { (10, 10), (20, 20), (40, 40) },

                    FirstProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (20, 0),
                                (22, 7),
                                (24, 7),
                                (27, 9),
                                (29, 9),
                                (32, 11),
                                (35, 11),
                                (39, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }
                    },
                    SecProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (20, 0),
                                (22, 7),
                                (24, 7),
                                (27, 9),
                                (29, 9),
                                (32, 11),
                                (35, 11),
                                (39, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    },
                    ThirdProductProduction = new Production()
                    {
                        ProductCapacityUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (20, 0) , (22, 7) , (24, 7) , (27, 9) , (29, 9) , (32, 11) , (35, 11) , (39, 13)
                            }
                        },
                        ProductCostUpgrade = new BuldingsUpgrades()
                        {
                            CurrentLvl = 0,
                            UpgradeCostEffectList = new List<(int, int)>()
                            {
                                (17, 0),
                                (15, 7),
                                (13, 7),
                                (11, 9),
                                (9, 9),
                                (6, 11),
                                (4, 11),
                                (1, 13)
                            }
                        }

                    }

                }
            };
        }
    }
}
    

