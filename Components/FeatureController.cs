/*
' Copyright (c) 2024 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Christoc.Modules.DNN_Angular_Module2.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for DNN_Angular_Module2
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<DNN_Angular_Module2Info> colDNN_Angular_Module2s = GetDNN_Angular_Module2s(ModuleID);
        //if (colDNN_Angular_Module2s.Count != 0)
        //{
        //    strXML += "<DNN_Angular_Module2s>";

        //    foreach (DNN_Angular_Module2Info objDNN_Angular_Module2 in colDNN_Angular_Module2s)
        //    {
        //        strXML += "<DNN_Angular_Module2>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDNN_Angular_Module2.Content) + "</content>";
        //        strXML += "</DNN_Angular_Module2>";
        //    }
        //    strXML += "</DNN_Angular_Module2s>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDNN_Angular_Module2s = DotNetNuke.Common.Globals.GetContent(Content, "DNN_Angular_Module2s");
        //foreach (XmlNode xmlDNN_Angular_Module2 in xmlDNN_Angular_Module2s.SelectNodes("DNN_Angular_Module2"))
        //{
        //    DNN_Angular_Module2Info objDNN_Angular_Module2 = new DNN_Angular_Module2Info();
        //    objDNN_Angular_Module2.ModuleId = ModuleID;
        //    objDNN_Angular_Module2.Content = xmlDNN_Angular_Module2.SelectSingleNode("content").InnerText;
        //    objDNN_Angular_Module2.CreatedByUser = UserID;
        //    AddDNN_Angular_Module2(objDNN_Angular_Module2);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<DNN_Angular_Module2Info> colDNN_Angular_Module2s = GetDNN_Angular_Module2s(ModInfo.ModuleID);

        //foreach (DNN_Angular_Module2Info objDNN_Angular_Module2 in colDNN_Angular_Module2s)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDNN_Angular_Module2.Content, objDNN_Angular_Module2.CreatedByUser, objDNN_Angular_Module2.CreatedDate, ModInfo.ModuleID, objDNN_Angular_Module2.ItemId.ToString(), objDNN_Angular_Module2.Content, "ItemId=" + objDNN_Angular_Module2.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
