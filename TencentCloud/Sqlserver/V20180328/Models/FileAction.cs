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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileAction : AbstractModel
    {
        
        /// <summary>
        /// Allowed operations. Valid values: `view` (view list), `remark` (modify remark), `deploy` (deploy files), `delete` (delete files).
        /// </summary>
        [JsonProperty("AllAction")]
        public string[] AllAction{ get; set; }

        /// <summary>
        /// Operation allowed in the current status. If the subset of `AllAction` is empty, no operations will be allowed.
        /// </summary>
        [JsonProperty("AllowedAction")]
        public string[] AllowedAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AllAction.", this.AllAction);
            this.SetParamArraySimple(map, prefix + "AllowedAction.", this.AllowedAction);
        }
    }
}

