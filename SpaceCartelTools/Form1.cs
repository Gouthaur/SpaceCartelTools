using KlikaczBot.SavingOptionsInFile;
using KlikaczBot.SavingOptionsInFile.JsonSerialser;
using SpaceCartelTools.SavingOptionsInFile.Hellpers;

namespace SpaceCartelTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileActionsInSystem = new FilesActions();
            jsonSerlizer = new JsonSerialsierJsoNewsoft(fileActionsInSystem);
            AppOptData = jsonSerlizer.LoadOptionsOnSystem("C:\\Users\\Gouth\\Documents\\SpaceCartelTools.json");
            NumUpSetUp();
            SetUpChekbox();
           
            _mineIroneOreCostUpLvl = AppOptData.MineBulding.FirstProductProduction.ProductCostUpgrade.CurrentLvl;
            _mineIroneOreCapUpLvl = AppOptData.MineBulding.FirstProductProduction.ProductCapacityUpgrade.CurrentLvl;
            _mineIronOreProduction = AppOptData.MineBulding.FirstProductProduction.ProductCapacityUpgrade.UpgradeCostEffectList[_mineIroneOreCostUpLvl].Item1 * AppOptData.PriceIronOre.Sell -  AppOptData.MineBulding.FirstProductProduction.ProductCapacityUpgrade.UpgradeCostEffectList[_mineIroneOreCostUpLvl].Item1
                * AppOptData.MineBulding.FirstProductProduction.ProductCostUpgrade.UpgradeCostEffectList[_mineIroneOreCostUpLvl].Item1/100 * AppOptData.PriceUran.Buy;








            _labMineIronCostLvlUp.Text = _mineIroneOreCostUpLvl.ToString(); 
            _labMineIronCapLvlUp.Text = _mineIroneOreCapUpLvl.ToString();
            _labMineIronProdction.Text = _mineIronOreProduction.ToString(); 






        }



        private int _mineIroneOreCapUpLvl { get; set; }
        private int _mineIroneOreCostUpLvl { get; set; }
        private decimal _mineIronOreProduction { get; set; }

        private void SetUpChekbox()
        {
            _cbMineIron.Checked = AppOptData.MineBulding.FirstProduct;
            if (_cbMineIron.Checked)
            {
                _cbMineIron.Enabled = false;
            }           
            
            _cbMineCopper.Checked = AppOptData.MineBulding.SecProduct;
            if (_cbMineCopper.Checked)
            {
                _cbMineCopper.Enabled = false;
            }
            _cbMineUran.Checked = AppOptData.MineBulding.ThirdProduct;
            if (_cbMineUran.Checked)
            {
                _cbMineUran.Enabled = false;
            }

            _cbSteelworkSteel.Checked = AppOptData.SteelworksBulding.FirstProduct;
            if (_cbSteelworkSteel.Checked)
            {
                _cbSteelworkSteel.Enabled = false;
            }
            _cbSteelworkCopper.Checked = AppOptData.SteelworksBulding.SecProduct;
            if (_cbSteelworkCopper.Checked)
            {
                _cbSteelworkCopper.Enabled = false;
            }
            _cbSteelworkUran.Checked = AppOptData.SteelworksBulding.ThirdProduct;
            if (_cbSteelworkUran.Checked)
            {
                _cbSteelworkUran.Enabled = false;
            }

            _cbShipYardRedShip.Checked = AppOptData.ShipyardBulding.FirstProduct;
            if (_cbShipYardRedShip.Checked)
            {
                _cbShipYardRedShip.Enabled = false;
            }
            _cbShipYardBlueShip.Checked = AppOptData.ShipyardBulding.SecProduct;
            if (_cbShipYardBlueShip.Checked)
            {
                _cbShipYardBlueShip.Enabled = false;
            }
            _cbShipYardOrangeShip.Checked = AppOptData.ShipyardBulding.ThirdProduct;
            if (_cbShipYardOrangeShip.Checked)
            {
                _cbShipYardOrangeShip.Enabled = false;
            }
        }

        private void NumUpSetUp()
        {
            _nupIronOreSell.Value = AppOptData.PriceIronOre.Sell;
            _nupIronOreBuy.Value = AppOptData.PriceIronOre.Buy;

            _nupCopperOreSell.Value = AppOptData.PriceCopperOre.Sell;
            _nupCopperOreBuy.Value = AppOptData.PriceCopperOre.Buy;

            _nupUranOreSell.Value = AppOptData.PriceUranOre.Sell;
            _nupUranOreBuy.Value = AppOptData.PriceUranOre.Buy;

            _nupSteelSell.Value = AppOptData.PriceSteel.Sell;
            _nupSteelBuy.Value = AppOptData.PriceSteel.Buy;

            _nupCopperSell.Value = AppOptData.PriceCopper.Sell;
            _nupCopperBuy.Value = AppOptData.PriceCopper.Buy;

            _nupUranSell.Value = AppOptData.PriceUran.Sell;
            _nupUranBuy.Value = AppOptData.PriceUran.Buy;

            _nupRedSeedSell.Value = AppOptData.PriceRedSeed.Sell;
            _nupRedSeedBuy.Value = AppOptData.PriceRedSeed.Buy;

            _nupBlueSeedSell.Value = AppOptData.PriceBlueSeed.Sell;
            _nupBlueSeedBuy.Value = AppOptData.PriceBlueSeed.Buy;

            _nupOrangeSeedSell.Value = AppOptData.PriceOrangeSeed.Sell;
            _nupOrangeSeedBuy.Value = AppOptData.PriceOrangeSeed.Buy;

            _nupRedFlowerSell.Value = AppOptData.PriceRedFlower.Sell;
            _nupRedFlowerBuy.Value = AppOptData.PriceRedFlower.Buy;

            _nupBlueFlowerSell.Value = AppOptData.PriceBlueFlower.Sell;
            _nupBlueFlowerBuy.Value = AppOptData.PriceBlueFlower.Buy;

            _nupOrangeFlowerSell.Value = AppOptData.PriceOrangeFlower.Sell;
            _nupOrangeFlowerBuy.Value = AppOptData.PriceOrangeFlower.Buy;

            _nupRedShipSell.Value = AppOptData.PriceRedShip.Sell;
            _nupRedShipBuy.Value = AppOptData.PriceRedShip.Buy;

            _nupBlueShipSell.Value = AppOptData.PriceBlueShip.Sell;
            _nupBlueShipBuy.Value = AppOptData.PriceBlueShip.Buy;

            _nupOrangeShipSell.Value = AppOptData.PriceOrangeShip.Sell;
            _nupOrangeShipBuy.Value = AppOptData.PriceOrangeShip.Buy;
        }

        IFileActionsInSystem fileActionsInSystem { get; set; }
        IJsonSerlizer jsonSerlizer { get; set; }
        public AppOptData AppOptData { get; set; }        


        private void button1_Click(object sender, EventArgs e)
        {
            //var init = new OptionFileInit();
            //AppOptData = init.Init();
            jsonSerlizer.SaveOptionsOnSystem(AppOptData, "C:\\Users\\Gouth\\Documents\\SpaceCartelTools.json");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _nupIronOreSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceIronOre.Sell = numUp.Value;
        }

        private void _nupIronOreBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceIronOre.Buy = numUp.Value;
        }

        private void _nupCopperOreSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceCopperOre.Sell = numUp.Value;
        }

        private void _nupCopperOreBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceCopperOre.Buy = numUp.Value;
        }

        private void _nupUranOreSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceUranOre.Sell = numUp.Value;
        }

        private void _nupUranOreBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceUranOre.Buy = numUp.Value;
        }

        private void _nupSteelSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceSteel.Sell = numUp.Value;
        }

        private void _nupSteelBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceSteel.Buy = numUp.Value;
        }

        private void _nupCopperSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceCopper.Sell = numUp.Value;
        }

        private void _nupCopperBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceCopper.Buy = numUp.Value;
        }

        private void _nupUranSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceUran.Sell = numUp.Value;
        }

        private void _nupUranBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceUran.Buy = numUp.Value;
        }

        private void _nupRedSeedSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedSeed.Sell = numUp.Value;
        }

        private void _nupRedSeedBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedSeed.Buy = numUp.Value;
        }

        private void _nupBlueSeedSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueSeed.Sell = numUp.Value;
        }

        private void _nupBlueSeedBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueSeed.Buy = numUp.Value;
        }

        private void _nupOrangeSeedSell_ValueChanged(object sender, EventArgs e)
        {

            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeSeed.Sell = numUp.Value;
        }

        private void _nupOrangeSeedBuy_ValueChanged(object sender, EventArgs e)
        {

            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeSeed.Buy = numUp.Value;
        }

        private void _nupRedFlowerSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedFlower.Sell = numUp.Value;
        }

        private void _nupRedFlowerBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedFlower.Buy = numUp.Value;
        }

        private void _nupBlueFlowerSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueFlower.Sell = numUp.Value;
        }

        private void _nupBlueFlowerBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueFlower.Buy = numUp.Value;
        }

        private void _nupOrangeFlowerSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeFlower.Sell = numUp.Value;
        }

        private void _nupOrangeFlowerBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeFlower.Buy = numUp.Value;
        }

        private void _nupRedShipSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedShip.Sell = numUp.Value;
        }

        private void _nupRedShipBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceRedShip.Buy = numUp.Value;
        }

        private void _nupBlueShipSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueShip.Sell = numUp.Value;
        }

        private void _nupBlueShipBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceBlueShip.Buy = numUp.Value;
        }

        private void _nupOrangeShipSell_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeShip.Sell = numUp.Value;
        }

        private void _nupOrangeShipBuy_ValueChanged(object sender, EventArgs e)
        {
            var numUp = sender as NumericUpDown;
            AppOptData.PriceOrangeShip.Buy = numUp.Value;
        }

        
    }
}