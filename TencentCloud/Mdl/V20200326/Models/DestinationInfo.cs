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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DestinationInfo : AbstractModel
    {
        
        /// <summary>
        /// Relay destination address. Length limit: [1,512].
        /// </summary>
        [JsonProperty("OutputUrl")]
        public string OutputUrl{ get; set; }

        /// <summary>
        /// Authentication key. Length limit: [1,128].
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }

        /// <summary>
        /// Authentication username. Length limit: [1,128].
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Authentication password. Length limit: [1,128].
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// The destination type of the retweet. Currently available values are: Standard, AWS_MediaPackageV1, AWS_MediaPackageV2. The default is: Standard.
        /// </summary>
        [JsonProperty("DestinationType")]
        public string DestinationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputUrl", this.OutputUrl);
            this.SetParamSimple(map, prefix + "AuthKey", this.AuthKey);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "DestinationType", this.DestinationType);
        }
    }
}

