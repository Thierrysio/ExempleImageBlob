using ExempleImageBlob.Modeles;
using ExempleImageBlob.VueModeles;

namespace ExempleImageBlob.Vues;

public partial class ImageVue : ContentPage
{
    ImageVueModele vueModele;
    public ImageVue()
    {
        InitializeComponent();
        BindingContext = vueModele = new ImageVueModele();
    }
    private async void toto_Clicked(object sender, EventArgs e)
    {
        // texte contenant la photo en base64
        string Photo64 = null;
        // désactivation du bouton pour eviter une nouvelle photo pendant l'execution de la methode
        (sender as Button).IsEnabled = false;
        // Vérification que la prise de photo est acceptée
        if (MediaPicker.Default.IsCaptureSupported)
        {
            // Prise de la photo
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            // verification de la photo 
            if (photo != null)
            {
               // mise en cacache de la photo
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
                // genere un flux d'octets de la photo
                using Stream sourceStream = await photo.OpenReadAsync();
                // convertit le flux en string au format base64
                using (MemoryStream memory = new MemoryStream())
                {

                    Photo64 = Services.Conversion.ConvertToBase64(sourceStream);
                }
            
            }
            // transforme la string (base64) en flux d'octets lisible par image
            image.Source = Services.Conversion.ConvertFromBase64(Photo64);
            // creation d'un user avec son image en base64
            vueModele.PostUser(new User("gg1hhjhg2", "xjjfxi2x2x", "xx2ixijjxx", Photo64, 0));


        }

(sender as Button).IsEnabled = true;

    }


}