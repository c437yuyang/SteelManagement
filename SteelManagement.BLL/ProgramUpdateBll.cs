using System;
using System.Data;
using System.Collections.Generic;
using SteelManagement.Model;
namespace SteelManagement.BLL
{
    /// <summary>
    /// ProgramUpdate
    /// </summary>
    public partial class ProgramUpdate
    {
        public Model.ProgramUpdate GetLatestModel()
        {
            return dal.GetLatestModel();
        }

        /// <summary>
        /// 根据当前版本获取需要更新的所有内容,按照版本从旧到新排列
        /// </summary>
        /// <param name="curVersion"></param>
        /// <returns></returns>
        public List<Model.ProgramUpdate> GetUpdateModelList(string curVersion)
        {
            var list = GetModelList(string.Format(" Version > {0}", curVersion));
            if (list != null)
            {
                list.Sort((model1, model2) =>
                {
                    return string.Compare(model1.Version, model2.Version);
                });
            }
            return list;
        }
    }
}

