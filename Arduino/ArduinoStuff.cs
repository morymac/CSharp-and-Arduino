using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sharpduino;

namespace Arduino1
{
    class ArduinoStuff
    {
        
        
        //Reads an Analog sensor and gives back its value from a Port number (int port)
        public static float RASensor(int pin, string port) {
         float value = 0;
         var Arduino = new ArduinoUno(port);
         switch (pin)
           {
               case 1:
                   value = Arduino.ReadAnalog(Sharpduino.Constants.ArduinoUnoAnalogPins.A1);
                   break;
               case 2:
                   value = Arduino.ReadAnalog(Sharpduino.Constants.ArduinoUnoAnalogPins.A2);
                   break;

               case 3:
                   value = Arduino.ReadAnalog(Sharpduino.Constants.ArduinoUnoAnalogPins.A3);
                   break;
               case 4:
                   value = Arduino.ReadAnalog(Sharpduino.Constants.ArduinoUnoAnalogPins.A4);
                   break;
               case 5:
                   value = Arduino.ReadAnalog(Sharpduino.Constants.ArduinoUnoAnalogPins.A5);
                   break;


           }
           
            return value;
        }
        // End RA Sensor
        public static void SetDO() {
        
        }
       

        
    }
}
