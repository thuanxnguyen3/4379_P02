//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Scripts/UI Buttons.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UIButtons : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIButtons()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UI Buttons"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""dd6befae-1b1c-46e8-9e52-2303ab0246b9"",
            ""actions"": [
                {
                    ""name"": ""MainMenu"",
                    ""type"": ""Button"",
                    ""id"": ""d4a49668-09d9-4896-aff1-c71cfc3a3a74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""993b88fe-8d20-4edf-97f2-404a4fdf3031"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3f479239-25e8-4194-8fca-2260ccd4f274"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Level Select"",
                    ""type"": ""Button"",
                    ""id"": ""c3646ca8-7405-43c9-9385-5a4cc66ddb8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""1bcced32-4819-41d6-aa8a-dabba9eab920"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""f7f4e86e-fdf2-4f9e-8e01-86c2708bb798"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""883fdd67-5c31-4c13-8cf0-172987358794"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""116f651b-de74-471b-b995-5624ea16b1cc"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e30ae924-22e0-48f6-83ec-4070572ae0ad"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d99302d6-85b5-4190-89fa-cad508443150"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Level Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40609e34-16a9-4277-95e9-59d04228f366"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""750eae80-c17c-4d4e-b458-13a83b1f6f90"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_MainMenu = m_UI.FindAction("MainMenu", throwIfNotFound: true);
        m_UI_Resume = m_UI.FindAction("Resume", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_LevelSelect = m_UI.FindAction("Level Select", throwIfNotFound: true);
        m_UI_Quit = m_UI.FindAction("Quit", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_MainMenu;
    private readonly InputAction m_UI_Resume;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_LevelSelect;
    private readonly InputAction m_UI_Quit;
    private readonly InputAction m_UI_Start;
    public struct UIActions
    {
        private @UIButtons m_Wrapper;
        public UIActions(@UIButtons wrapper) { m_Wrapper = wrapper; }
        public InputAction @MainMenu => m_Wrapper.m_UI_MainMenu;
        public InputAction @Resume => m_Wrapper.m_UI_Resume;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @LevelSelect => m_Wrapper.m_UI_LevelSelect;
        public InputAction @Quit => m_Wrapper.m_UI_Quit;
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @MainMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMainMenu;
                @MainMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMainMenu;
                @MainMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMainMenu;
                @Resume.started -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnResume;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @LevelSelect.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLevelSelect;
                @Quit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnQuit;
                @Start.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MainMenu.started += instance.OnMainMenu;
                @MainMenu.performed += instance.OnMainMenu;
                @MainMenu.canceled += instance.OnMainMenu;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @LevelSelect.started += instance.OnLevelSelect;
                @LevelSelect.performed += instance.OnLevelSelect;
                @LevelSelect.canceled += instance.OnLevelSelect;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnMainMenu(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnLevelSelect(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
