//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Settings/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""78562fad-3d2e-44f7-865d-f3041a0ae2d5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7d7113d5-4112-4d0b-ba30-c53572b761f3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""c92b7ecd-4d1a-4b39-80a7-bf043c5fc033"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""d83cf625-817d-4feb-ad56-8f1bf83263e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""83168cc4-a597-4e3d-ac3c-fb8b2a453a85"",
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
                    ""id"": ""c09f429c-aaf0-4780-8475-9da916cb279f"",
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
                    ""id"": ""90498d6c-990d-4dd5-b323-c5c22f4a3bf4"",
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
                    ""id"": ""2a96e071-0136-485d-93b8-03b46d05b7bb"",
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
                    ""id"": ""225a2733-784f-4632-8633-a1d16ba7140d"",
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
                    ""id"": ""1b1cb3a1-31bd-48ad-a180-571058ec055d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e36eb4a1-6d57-461e-a274-b69b5a7f550d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18b08adb-a79b-40e9-b8ce-f3777de720d6"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapons"",
            ""id"": ""b3201bc4-2ea7-43ad-98bd-af95d180e2c1"",
            ""actions"": [
                {
                    ""name"": ""SwitchTo1"",
                    ""type"": ""Button"",
                    ""id"": ""96641d80-8b4f-4505-aa6a-4439a87a938b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchTo2"",
                    ""type"": ""Button"",
                    ""id"": ""50d0b452-0e91-491f-87c3-b5a171c2e308"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchTo3"",
                    ""type"": ""Button"",
                    ""id"": ""1323e492-c325-4f61-be30-85e9805bfc99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""96063ab2-dbe3-4b05-a2d9-a1d364d6f511"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTo1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""183cdca1-8973-4c68-aa52-ea1670704391"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTo2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33040627-c419-46d3-a796-1ea9471817bd"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchTo3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
        // Weapons
        m_Weapons = asset.FindActionMap("Weapons", throwIfNotFound: true);
        m_Weapons_SwitchTo1 = m_Weapons.FindAction("SwitchTo1", throwIfNotFound: true);
        m_Weapons_SwitchTo2 = m_Weapons.FindAction("SwitchTo2", throwIfNotFound: true);
        m_Weapons_SwitchTo3 = m_Weapons.FindAction("SwitchTo3", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Dash;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Dash => m_Wrapper.m_Player_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Weapons
    private readonly InputActionMap m_Weapons;
    private IWeaponsActions m_WeaponsActionsCallbackInterface;
    private readonly InputAction m_Weapons_SwitchTo1;
    private readonly InputAction m_Weapons_SwitchTo2;
    private readonly InputAction m_Weapons_SwitchTo3;
    public struct WeaponsActions
    {
        private @PlayerControls m_Wrapper;
        public WeaponsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchTo1 => m_Wrapper.m_Weapons_SwitchTo1;
        public InputAction @SwitchTo2 => m_Wrapper.m_Weapons_SwitchTo2;
        public InputAction @SwitchTo3 => m_Wrapper.m_Weapons_SwitchTo3;
        public InputActionMap Get() { return m_Wrapper.m_Weapons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponsActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponsActions instance)
        {
            if (m_Wrapper.m_WeaponsActionsCallbackInterface != null)
            {
                @SwitchTo1.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo1;
                @SwitchTo1.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo1;
                @SwitchTo1.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo1;
                @SwitchTo2.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo2;
                @SwitchTo2.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo2;
                @SwitchTo2.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo2;
                @SwitchTo3.started -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo3;
                @SwitchTo3.performed -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo3;
                @SwitchTo3.canceled -= m_Wrapper.m_WeaponsActionsCallbackInterface.OnSwitchTo3;
            }
            m_Wrapper.m_WeaponsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SwitchTo1.started += instance.OnSwitchTo1;
                @SwitchTo1.performed += instance.OnSwitchTo1;
                @SwitchTo1.canceled += instance.OnSwitchTo1;
                @SwitchTo2.started += instance.OnSwitchTo2;
                @SwitchTo2.performed += instance.OnSwitchTo2;
                @SwitchTo2.canceled += instance.OnSwitchTo2;
                @SwitchTo3.started += instance.OnSwitchTo3;
                @SwitchTo3.performed += instance.OnSwitchTo3;
                @SwitchTo3.canceled += instance.OnSwitchTo3;
            }
        }
    }
    public WeaponsActions @Weapons => new WeaponsActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IWeaponsActions
    {
        void OnSwitchTo1(InputAction.CallbackContext context);
        void OnSwitchTo2(InputAction.CallbackContext context);
        void OnSwitchTo3(InputAction.CallbackContext context);
    }
}
