using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public static class SoundManager
    {
        // Must be private for some reason she'll explain later
        private static List<Sound> getSounds()
        {
            // Creating a list of sounds
            // Variable declaration = instantiation
            // List<Sound> sounds = new List<Sound>();

            // Var infers type from right hand side
            // Must be initialized 
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            return sounds;
        }
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();

            // Lambda
            allSounds.ForEach(s => sounds.Add(s));
        }
        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(s => s.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(s => sounds.Add(s));
        }

    }
}
