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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiKey : AbstractModel
    {
        
        /// <summary>
        /// Created API key ID.
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// Created API key.
        /// </summary>
        [JsonProperty("AccessKeySecret")]
        public string AccessKeySecret{ get; set; }

        /// <summary>
        /// Key type. Valid values: auto, manual.
        /// </summary>
        [JsonProperty("AccessKeyType")]
        public string AccessKeyType{ get; set; }

        /// <summary>
        /// Custom key name.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public string ModifiedTime{ get; set; }

        /// <summary>
        /// Key status. 0: disabled. 1: enabled.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "AccessKeySecret", this.AccessKeySecret);
            this.SetParamSimple(map, prefix + "AccessKeyType", this.AccessKeyType);
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

