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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMailProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// Email configurations
        /// </summary>
        [JsonProperty("ProfileInfo")]
        public ProfileInfo ProfileInfo{ get; set; }

        /// <summary>
        /// Configuration level. Valid values: "User" (user-level), "Instance" (instance-level). For database inspection report, it should be `User`; and for scheduled task reports, it should be `Instance`.
        /// </summary>
        [JsonProperty("ProfileLevel")]
        public string ProfileLevel{ get; set; }

        /// <summary>
        /// Configuration name, which needs to be unique. For database inspection reports, this name can be customize as needed. For scheduled task reports, the name should be in the format of "scheduler_" + {instanceId}, such as "schduler_cdb-test".
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// Configuration type. Valid values: "dbScan_mail_configuration" (email configuration of database inspection report), "scheduler_mail_configuration" (email configuration of scheduled task report).
        /// </summary>
        [JsonProperty("ProfileType")]
        public string ProfileType{ get; set; }

        /// <summary>
        /// Service type. Valid values: `mysql` (TencentDB for MySQL), `cynosdb` (TencentDB for CynosDB (compatible with MySQL)).
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Instance ID bound to the configuration, which is required when the configuration level is `Instance`.
        /// </summary>
        [JsonProperty("BindInstanceIds")]
        public string[] BindInstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProfileInfo.", this.ProfileInfo);
            this.SetParamSimple(map, prefix + "ProfileLevel", this.ProfileLevel);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamSimple(map, prefix + "ProfileType", this.ProfileType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "BindInstanceIds.", this.BindInstanceIds);
        }
    }
}

