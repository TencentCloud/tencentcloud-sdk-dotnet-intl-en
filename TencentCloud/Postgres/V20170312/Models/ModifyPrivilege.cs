/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPrivilege : AbstractModel
    {
        
        /// <summary>
        /// Specifies the database object and permission list to be modified.
        /// </summary>
        [JsonProperty("DatabasePrivilege")]
        public DatabasePrivilege DatabasePrivilege{ get; set; }

        /// <summary>
        /// Modifies via grantObject, revokeObject, or alterRole. grantObject represents authorization, revokeObject represents withdraw, alterRole represents modify account type.
        /// </summary>
        [JsonProperty("ModifyType")]
        public string ModifyType{ get; set; }

        /// <summary>
        /// This parameter is required only when ModifyType is revokeObject. when set to true, the permission will be revoked with cascading effect. default false.
        /// </summary>
        [JsonProperty("IsCascade")]
        public bool? IsCascade{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DatabasePrivilege.", this.DatabasePrivilege);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "IsCascade", this.IsCascade);
        }
    }
}

