/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatabaseRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource ID, which is the TCHouse-D resource ID used for table creation.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Use the user who has corresponding permissions for operations. If the TCHouse-D cluster uses a kernel account registered by a CAM user, you do not need to fill it in.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Password corresponding to the user. If the TCHouse-D cluster uses a kernel account registered by a CAM user, you do not need to fill it in.
        /// </summary>
        [JsonProperty("PassWord")]
        public string PassWord{ get; set; }

        /// <summary>
        /// Query the data source where the database is located. If it is not filled in, the internal data source (internal) will be used by default.
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// The database information to be queried. If this parameter and FilterDbName are not filled in, all database information of the current data source will be queried by default.
        /// </summary>
        [JsonProperty("DbNames")]
        public string[] DbNames{ get; set; }

        /// <summary>
        /// Display the filtered database information. For example, %infor indicates database names ending with infor. This parameter only supports scenarios where CatalogName is internal.
        /// </summary>
        [JsonProperty("FilterDbName")]
        public string FilterDbName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamArraySimple(map, prefix + "DbNames.", this.DbNames);
            this.SetParamSimple(map, prefix + "FilterDbName", this.FilterDbName);
        }
    }
}
