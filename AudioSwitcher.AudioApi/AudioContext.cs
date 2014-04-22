﻿namespace AudioSwitcher.AudioApi
{
    public abstract class AudioContext
    {
        protected AudioContext(AudioController controller, IPreferredDeviceManager preferredDeviceManager)
        {
            Controller = controller;
            PreferredDeviceManager = preferredDeviceManager;

            if (Controller != null)
                Controller.Context = this;

            if (PreferredDeviceManager != null)
                PreferredDeviceManager.Context = this;
        }

        public AudioController Controller { get; private set; }

        public IPreferredDeviceManager PreferredDeviceManager { get; private set; }
    }
}