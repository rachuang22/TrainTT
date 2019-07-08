/************************************************************************************

Copyright   :   Copyright 2017-Present Oculus VR, LLC. All Rights reserved.

Licensed under the Oculus VR Rift SDK License Version 3.2 (the "License");
you may not use the Oculus VR Rift SDK except in compliance with the License,
which is provided at the time of installation or download, or which
otherwise accompanies this software in either electronic or hard copy form.

You may obtain a copy of the License at

http://www.oculusvr.com/licenses/LICENSE-3.2

Unless required by applicable law or agreed to in writing, the Oculus VR SDK
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIInteraction : MonoBehaviour {
    public UnityEngine.UI.Text outText;

	public void OnButtonClicked() {
<<<<<<< HEAD
        SceneManager.LoadScene("Neighborhood");
        Debug.Log("lol");
=======
        SceneManager.LoadScene(1);
>>>>>>> 071d1b84c53d08e064e9fd729178be2588081e7e
    }

    public void OnSliderChanged(float value) {
        if (outText != null) {
            outText.text = "<b>Last Interaction:</b>\nUI Slider value: " + value;
        }
    }

	public void OnToggleChanged(bool value) {
		if (outText != null) {
			outText.text = "<b>Last Interaction:</b>\nUI toggle value: " + value;
		}
	}

	public void OnClearText() {
		if (outText != null) {
			outText.text = "";
		}
	}

    public void OnBackToMenu() {
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }

}