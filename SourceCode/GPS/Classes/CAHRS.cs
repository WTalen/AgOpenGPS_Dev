using Tinkerforge;

namespace AgOpenGPS
{
    public class CAHRS
    {
        private readonly FormGPS mf;

        ////Kalman variables
        //private double rollK = 0;
        //private double Pc = 0.0;
        //private double G = 0.0;
        //private double P = 1.0;
        //private double Xp = 0.0;
        //private double Zp = 0.0;
        //private double XeRoll = 0;
        //private readonly double varRoll = 0.06; // variance, smaller, more faster filtering
        //private readonly double varProcess = 0.02;

        public bool isHeadingBNO, isHeadingBrick, isRollDogs, isRollBrick;
        public int rollZero, pitchZero;

        //constructor
        public CAHRS(FormGPS _f)
        {
            mf = _f;

            //non GPS AHRS sensors
            isHeadingBNO = Properties.Settings.Default.setIMU_isHeadingFromBNO;
            isHeadingBrick = Properties.Settings.Default.setIMU_isHeadingFromBrick;
            isRollDogs = Properties.Settings.Default.setIMU_isRollFromDogs;
            isRollBrick = Properties.Settings.Default.setIMU_isRollFromBrick;

            rollZero = Properties.Settings.Default.setIMU_rollZero;
        }

        //event for TinkerForge IMU
        public void OrientCB(BrickIMUV2 sender, short heading, short roll, short pitch)
        {
            ////input to the Kalman
            //rollK = roll;

            ////Kalman filter
            //Pc = P + varProcess;
            //G = Pc / (Pc + varRoll);
            //P = (1 - G) * Pc;
            //Xp = XeRoll;
            //Zp = Xp;
            //XeRoll = (G * (rollK - Zp)) + Xp;

            if (isHeadingBrick)
            {
                mf.mc.prevGyroHeading = mf.mc.gyroHeading;
                mf.mc.gyroHeading = heading;
            }

            if (isRollBrick) mf.mc.rollRaw = roll;
        }
    }
}