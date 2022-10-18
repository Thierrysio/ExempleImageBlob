using ExempleImageBlob.Modeles;
using ExempleImageBlob.VuesModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleImageBlob.VueModeles
{
    internal class ImageVueModele : BaseVueModele
    {
        #region Attributs
        private User _monUser;
        #endregion
        #region Getters/Setters
        public User MonUser
        {
            get { return _monUser; ; }
            set { SetProperty(ref _monUser, value); }
        }

        #endregion

        #region Methodes
        public async void PostUser(User unUser)
        {

        }


        #endregion
    }
}
