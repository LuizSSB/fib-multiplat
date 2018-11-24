using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace FormsDemo
{
    public class FileViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler
            PropertyChanged;

        string mText;
        public string Text
        {
            get => mText;
            set
            {
                mText = value;
                PropertyChanged?
                    .Invoke(
                        this,
                        new PropertyChangedEventArgs(
                            "Text"
                        )
                    );
            }
        }

        bool mIsWorking = true;
        public bool IsWorking
        {
            get => mIsWorking;
            set
            {
                mIsWorking = value;
                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs("IsWorking")
                );
            }
        }

        public Command SaveCommand { get; private set; }

        public static readonly string FilePath =
            Path.Combine(
                FileSystem.AppDataDirectory, "text.txt"
            );

        public FileViewModel()
        {
            SaveCommand = new Command<string>(async (newText) => {
                IsWorking = false;

                var request = new GeolocationRequest(
                    GeolocationAccuracy.Medium
                );

                try {
                    var location = await Geolocation
                        .GetLocationAsync(request);
                    var placemarks = await Geocoding
                             .GetPlacemarksAsync(location);
                    var placemark = placemarks.First();
                    var city = placemark.SubAdminArea ??
                                        placemark.Locality;
                    newText = city + ": " + newText;
                } catch (Exception e) {
                    newText = "Lugar desconhecido: " + newText;
                    Console.WriteLine(e);
                }

                Text = newText + "\n" + Text;
                try {
                    File.WriteAllText(
                        FilePath, Text
                    );
                    IsWorking = true;
                } catch {
                    Text = "Não deu pra salvar";
                }
            });

            if (File.Exists(FilePath)) {
                Text = File.ReadAllText(FilePath);
            }
        }
    }
}
