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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSchedulerMailProfileRequest : AbstractModel
    {
        
        /// <summary>
        /// Value range: 1–7, representing Monday to Sunday respectively.
        /// </summary>
        [JsonProperty("WeekConfiguration")]
        public long?[] WeekConfiguration{ get; set; }

        /// <summary>
        /// Email configuration.
        /// </summary>
        [JsonProperty("ProfileInfo")]
        public ProfileInfo ProfileInfo{ get; set; }

        /// <summary>
        /// Configuration name, which needs to be unique. For scheduled task emails, the name should be in the format of "scheduler_" + {instanceId}, such as "schduler_cdb-test".
        /// </summary>
        [JsonProperty("ProfileName")]
        public string ProfileName{ get; set; }

        /// <summary>
        /// ID of the instance for which to configure subscription.
        /// </summary>
        [JsonProperty("BindInstanceId")]
        public string BindInstanceId{ get; set; }

        /// <summary>
        /// Service type. Valid values: mysql (TencentDB for MySQL), cynosdb (TDSQL-C for MySQL). Default value: mysql.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WeekConfiguration.", this.WeekConfiguration);
            this.SetParamObj(map, prefix + "ProfileInfo.", this.ProfileInfo);
            this.SetParamSimple(map, prefix + "ProfileName", this.ProfileName);
            this.SetParamSimple(map, prefix + "BindInstanceId", this.BindInstanceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

