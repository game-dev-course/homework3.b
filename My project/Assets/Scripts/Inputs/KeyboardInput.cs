using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        //note that i used the unity name input for me vertical is a d and horizontal is left and right arrow 
        //it may not work if you open it in unity your self because its my project configrotion for the movement names(it may work i did not tried to do it)
        //Accelerate is up arrow and there is anouter name calledc Accelerate2 is w
        //same for Brake and Brake2 but with down and s keys
        public string TurnInputName = "Vertical";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";
        //this is just the default keys is choose you shood change it depending on the object you put the script on
        //*not change in code but in the editor it self you can choose the values
        public override InputData GenerateInput() {
            string a = TurnInputName;
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis(a)
            };
        }
    }
}
