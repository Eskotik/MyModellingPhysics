using System;
using System.Collections.Generic;

namespace Project_v3._0
{
    public static class LifeCycle
    {

        public static void OnCreateInputMode() 
        {
            MainWindow.mode = MODE.INPUT;
            Console.WriteLine($"OnCreateInputMode");
            List<Data> tmpData = new List<Data>();
            Data Tdata = Data.this_.GetDataFromInputs();
            if (Tdata == null)
                return;
            tmpData.Add(Tdata);
            DrawingInstruments.Display(tmpData);
        }
        public static void OnRemoveInputMode()
        {
            MainWindow.selection_ball = SELECTION_BALL.NONE;
            MainWindow.clicked_ball = CLICKED_BALL.NONE;
            MainWindow.clicked_vector_setup_ball = CLICKED_FOR_VECTOR_SETUP_BALL.NONE;
            Console.WriteLine($"OnRemoveInputMode");
        }

        public static void OnCreateOutputMode()
        {
            MainWindow.mode = MODE.OUTPUT;
            Console.WriteLine($"OnCreateOutputMode");
        }
        public static void OnRemoveOutputMode()
        {
            Console.WriteLine($"OnRemoveOutputMode");

        }

        public static void OnCreateMovementMode()
        {
            MainWindow.mode = MODE.MOVEMENT;
            Console.WriteLine($"OnCreateMovementMode");
        }
        public static void OnRemoveMovementMode()
        {
            Console.WriteLine($"OnRemoveMovementMode");
        }


        public static void OnCreateVectorSetupMode()
        {
            MainWindow.mode = MODE.VECTOR_SETUP;
            Console.WriteLine($"OnCreateVectorSetupMode");
        }
        public static void OnRemoveVectorSetupMode()
        {
            Console.WriteLine($"OnRemoveVectorSetupMode");
        } 
        public static void OnCreateStraightSystem()
        {
            Console.WriteLine($"OnCreateStraightMode =В");

            if (Data.this_ != null)
            {
                MainWindow.location_system = LOCATION_SYSTEM.STRAIGHT;
            }
        } 
        public static void OnRemoveStraightSystem()
        {
            Console.WriteLine($"OnRemoveStraightMode");
        }
 
        public static void OnCreateArbitrarySystem()
        {
            MainWindow.location_system = LOCATION_SYSTEM.ARBITRARY;
            Console.WriteLine($"OnCreateArbitrarySystem");



        }
        public static void OnRemoveArbitrarySystem()
        {
            Console.WriteLine($"OnRemoveArbitrarySystem");
        }
    }
}
