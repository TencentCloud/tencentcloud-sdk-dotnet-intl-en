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

    public class CopyTableDatasRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource ID, which is the TCHouse-D resource ID used for table creation.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Name of the database where the source table is located
        /// </summary>
        [JsonProperty("CopiedFromDb")]
        public string CopiedFromDb{ get; set; }

        /// <summary>
        /// Source table name
        /// </summary>
        [JsonProperty("CopiedFromTable")]
        public string CopiedFromTable{ get; set; }

        /// <summary>
        /// Name of the database where the target table is located
        /// </summary>
        [JsonProperty("CopyToDb")]
        public string CopyToDb{ get; set; }

        /// <summary>
        /// Target table name. If the table already exists, the structure of the source table and target table should be the same.
        /// </summary>
        [JsonProperty("CopyToTable")]
        public string CopyToTable{ get; set; }

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
        /// Whether the data in the target table is overwritten. The default value is False.
        /// </summary>
        [JsonProperty("IsDataOverwrite")]
        public bool? IsDataOverwrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CopiedFromDb", this.CopiedFromDb);
            this.SetParamSimple(map, prefix + "CopiedFromTable", this.CopiedFromTable);
            this.SetParamSimple(map, prefix + "CopyToDb", this.CopyToDb);
            this.SetParamSimple(map, prefix + "CopyToTable", this.CopyToTable);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "IsDataOverwrite", this.IsDataOverwrite);
        }
    }
}

