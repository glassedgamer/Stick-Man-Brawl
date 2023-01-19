//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Players/Player Inputs/P1.inputactions
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

public partial class @P1_Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @P1_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""P1"",
    ""maps"": [
        {
            ""name"": ""P1"",
            ""id"": ""6dafa46d-7083-4cf1-8e68-f56ededa937e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6697feb2-d44f-4d28-bd20-b8f87ab3013a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""55daadec-62f7-4fe8-9d80-67faab23906d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""737f5ccc-312b-420f-a6e9-9538f014a180"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""23102856-4ccb-4ea7-b30a-6f082ffde421"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""61a28cce-92e2-4641-9406-01931410987e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""405916f4-0020-4749-91df-8d49713448e8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f111a7fb-add8-44cc-aee4-9fe8279421a7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""060b18d5-28c1-4003-8192-526fde88e3d2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7f8a07e6-992c-4134-ba9a-c976b12050e8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""fc8842bd-ca9e-43a0-bb2f-831736a72829"",
            ""actions"": [
                {
                    ""name"": ""Pausing"",
                    ""type"": ""Button"",
                    ""id"": ""6e9ae548-c108-4c9c-bb28-4f6303b628d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""deda76ec-a1be-4125-8a36-0b1241e52288"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe50a9f8-09db-4263-84b8-5bee0d3e2449"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pausing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a4309a8-f1e0-4add-bc3f-305acb21cd3c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // P1
        m_P1 = asset.FindActionMap("P1", throwIfNotFound: true);
        m_P1_Movement = m_P1.FindAction("Movement", throwIfNotFound: true);
        m_P1_Attack = m_P1.FindAction("Attack", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Pausing = m_Menu.FindAction("Pausing", throwIfNotFound: true);
        m_Menu_Enter = m_Menu.FindAction("Enter", throwIfNotFound: true);
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

    // P1
    private readonly InputActionMap m_P1;
    private IP1Actions m_P1ActionsCallbackInterface;
    private readonly InputAction m_P1_Movement;
    private readonly InputAction m_P1_Attack;
    public struct P1Actions
    {
        private @P1_Controls m_Wrapper;
        public P1Actions(@P1_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_P1_Movement;
        public InputAction @Attack => m_Wrapper.m_P1_Attack;
        public InputActionMap Get() { return m_Wrapper.m_P1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(P1Actions set) { return set.Get(); }
        public void SetCallbacks(IP1Actions instance)
        {
            if (m_Wrapper.m_P1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_P1ActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_P1ActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_P1ActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_P1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public P1Actions @P1 => new P1Actions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Pausing;
    private readonly InputAction m_Menu_Enter;
    public struct MenuActions
    {
        private @P1_Controls m_Wrapper;
        public MenuActions(@P1_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pausing => m_Wrapper.m_Menu_Pausing;
        public InputAction @Enter => m_Wrapper.m_Menu_Enter;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Pausing.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPausing;
                @Pausing.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPausing;
                @Pausing.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPausing;
                @Enter.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pausing.started += instance.OnPausing;
                @Pausing.performed += instance.OnPausing;
                @Pausing.canceled += instance.OnPausing;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IP1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnPausing(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
}