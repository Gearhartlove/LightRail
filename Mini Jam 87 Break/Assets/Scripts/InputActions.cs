// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c8ed5845-9666-41d7-b334-af281111f9bf"",
            ""actions"": [
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""87304e42-8e49-474f-a5db-c14875c3f564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""677cd275-e9d8-4835-82b0-bbd0e500c7c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""7c0f54d6-c201-4e84-adcf-4ce1b2e4b13d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""f86571f2-dc07-4be6-be2e-6c845bd03241"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1bd4cc3b-758c-445b-b6f8-520620487e22"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de529e3d-67f4-4bdd-b124-f8c32be28f85"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fec9a2b-fc05-4666-931a-951eaffc9259"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38bcd67a-1a77-42b7-a0b0-08a106c7e0a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
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
        m_Player_North = m_Player.FindAction("North", throwIfNotFound: true);
        m_Player_West = m_Player.FindAction("West", throwIfNotFound: true);
        m_Player_South = m_Player.FindAction("South", throwIfNotFound: true);
        m_Player_East = m_Player.FindAction("East", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_North;
    private readonly InputAction m_Player_West;
    private readonly InputAction m_Player_South;
    private readonly InputAction m_Player_East;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @North => m_Wrapper.m_Player_North;
        public InputAction @West => m_Wrapper.m_Player_West;
        public InputAction @South => m_Wrapper.m_Player_South;
        public InputAction @East => m_Wrapper.m_Player_East;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @North.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNorth;
                @West.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWest;
                @South.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSouth;
                @East.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEast;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnNorth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
    }
}
