//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.10.0
//     from Assets/Input/PlayerInputController.inputactions
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

public partial class @PlayerInputController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputController"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""b751eefe-f76f-42f5-8bf2-10e834accea6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b982dca5-c4b4-406c-855e-a55ca5f1bc1e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""8a722964-9eb8-4385-b8d0-54049a45aafb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""bea7056d-f6f5-44a8-9a4e-d95fba4ad703"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""c6dd7f37-3bf3-4d48-8f87-9986b5fa3301"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""15522f07-9c6b-418e-b8e0-4d189e5798b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""1017f100-6fca-488d-a6b3-2c0c04711b3c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grenade"",
                    ""type"": ""Button"",
                    ""id"": ""09cc7d01-de6c-4447-bbc7-06696acc2ad9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""fbfa8fb1-46a0-4fed-97e4-625654454cb5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""4592f69c-089f-45ed-8f91-e63e2b94a1b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e0f0423c-99b5-41ff-bffd-e975a2a8dc41"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AlternateFire"",
                    ""type"": ""Button"",
                    ""id"": ""bf6dc569-4ee2-4d99-8adf-092ffad4eebf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondaryFire"",
                    ""type"": ""Button"",
                    ""id"": ""57ebe9e7-52ce-4b56-bd63-f922cc75c015"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9706ea8c-a7a4-4f95-b9b4-b0c4c09c827d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3235c77e-4736-4612-8cb0-b2f366e325c1"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47523fe7-99f7-461e-a189-c75aadee5187"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a151771a-9584-47f0-8dc8-9fc717d14419"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AlternateFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""183dce92-120f-455f-9f9b-8dfc473a5135"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bd1af548-1d92-43f8-bf6e-313252b3df8f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8d4f480d-7462-4306-9ebc-952f8871ff78"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a15afa4a-8a2f-47ed-9e61-f3567cd6d9d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d0056d4-07f3-4846-81e3-b68e7f3c31e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6509ac3-423f-4859-b1f1-29f96c1ecfc6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""59612a68-687d-4511-92c2-fa0310d515ec"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2cb22ac-0714-407d-9382-d62133e67fc4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bac5a1c6-795c-4c0c-a978-76df604757d6"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a19ce405-18d9-421b-9a95-8354853b2306"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2177a182-790f-41c0-9e1f-ee9fd990968a"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e9556c8-9f37-41d0-ab9b-1aef4c964bd3"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3d0a151-3079-4b8b-a65a-48c4c878b1ad"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Control Scheme"",
            ""bindingGroup"": ""Control Scheme"",
            ""devices"": []
        }
    ]
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Move = m_PlayerInput.FindAction("Move", throwIfNotFound: true);
        m_PlayerInput_Run = m_PlayerInput.FindAction("Run", throwIfNotFound: true);
        m_PlayerInput_Look = m_PlayerInput.FindAction("Look", throwIfNotFound: true);
        m_PlayerInput_Scroll = m_PlayerInput.FindAction("Scroll", throwIfNotFound: true);
        m_PlayerInput_Jump = m_PlayerInput.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInput_Reload = m_PlayerInput.FindAction("Reload", throwIfNotFound: true);
        m_PlayerInput_Grenade = m_PlayerInput.FindAction("Grenade", throwIfNotFound: true);
        m_PlayerInput_Crouch = m_PlayerInput.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerInput_Interact = m_PlayerInput.FindAction("Interact", throwIfNotFound: true);
        m_PlayerInput_Fire = m_PlayerInput.FindAction("Fire", throwIfNotFound: true);
        m_PlayerInput_AlternateFire = m_PlayerInput.FindAction("AlternateFire", throwIfNotFound: true);
        m_PlayerInput_SecondaryFire = m_PlayerInput.FindAction("SecondaryFire", throwIfNotFound: true);
    }

    ~@PlayerInputController()
    {
        UnityEngine.Debug.Assert(!m_PlayerInput.enabled, "This will cause a leak and performance issues, PlayerInputController.PlayerInput.Disable() has not been called.");
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

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private List<IPlayerInputActions> m_PlayerInputActionsCallbackInterfaces = new List<IPlayerInputActions>();
    private readonly InputAction m_PlayerInput_Move;
    private readonly InputAction m_PlayerInput_Run;
    private readonly InputAction m_PlayerInput_Look;
    private readonly InputAction m_PlayerInput_Scroll;
    private readonly InputAction m_PlayerInput_Jump;
    private readonly InputAction m_PlayerInput_Reload;
    private readonly InputAction m_PlayerInput_Grenade;
    private readonly InputAction m_PlayerInput_Crouch;
    private readonly InputAction m_PlayerInput_Interact;
    private readonly InputAction m_PlayerInput_Fire;
    private readonly InputAction m_PlayerInput_AlternateFire;
    private readonly InputAction m_PlayerInput_SecondaryFire;
    public struct PlayerInputActions
    {
        private @PlayerInputController m_Wrapper;
        public PlayerInputActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerInput_Move;
        public InputAction @Run => m_Wrapper.m_PlayerInput_Run;
        public InputAction @Look => m_Wrapper.m_PlayerInput_Look;
        public InputAction @Scroll => m_Wrapper.m_PlayerInput_Scroll;
        public InputAction @Jump => m_Wrapper.m_PlayerInput_Jump;
        public InputAction @Reload => m_Wrapper.m_PlayerInput_Reload;
        public InputAction @Grenade => m_Wrapper.m_PlayerInput_Grenade;
        public InputAction @Crouch => m_Wrapper.m_PlayerInput_Crouch;
        public InputAction @Interact => m_Wrapper.m_PlayerInput_Interact;
        public InputAction @Fire => m_Wrapper.m_PlayerInput_Fire;
        public InputAction @AlternateFire => m_Wrapper.m_PlayerInput_AlternateFire;
        public InputAction @SecondaryFire => m_Wrapper.m_PlayerInput_SecondaryFire;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInputActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Scroll.started += instance.OnScroll;
            @Scroll.performed += instance.OnScroll;
            @Scroll.canceled += instance.OnScroll;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @Grenade.started += instance.OnGrenade;
            @Grenade.performed += instance.OnGrenade;
            @Grenade.canceled += instance.OnGrenade;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @AlternateFire.started += instance.OnAlternateFire;
            @AlternateFire.performed += instance.OnAlternateFire;
            @AlternateFire.canceled += instance.OnAlternateFire;
            @SecondaryFire.started += instance.OnSecondaryFire;
            @SecondaryFire.performed += instance.OnSecondaryFire;
            @SecondaryFire.canceled += instance.OnSecondaryFire;
        }

        private void UnregisterCallbacks(IPlayerInputActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Scroll.started -= instance.OnScroll;
            @Scroll.performed -= instance.OnScroll;
            @Scroll.canceled -= instance.OnScroll;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @Grenade.started -= instance.OnGrenade;
            @Grenade.performed -= instance.OnGrenade;
            @Grenade.canceled -= instance.OnGrenade;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @AlternateFire.started -= instance.OnAlternateFire;
            @AlternateFire.performed -= instance.OnAlternateFire;
            @AlternateFire.canceled -= instance.OnAlternateFire;
            @SecondaryFire.started -= instance.OnSecondaryFire;
            @SecondaryFire.performed -= instance.OnSecondaryFire;
            @SecondaryFire.canceled -= instance.OnSecondaryFire;
        }

        public void RemoveCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInputActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInputActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInputActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    private int m_ControlSchemeSchemeIndex = -1;
    public InputControlScheme ControlSchemeScheme
    {
        get
        {
            if (m_ControlSchemeSchemeIndex == -1) m_ControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Control Scheme");
            return asset.controlSchemes[m_ControlSchemeSchemeIndex];
        }
    }
    public interface IPlayerInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnGrenade(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnAlternateFire(InputAction.CallbackContext context);
        void OnSecondaryFire(InputAction.CallbackContext context);
    }
}
