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
        /// Authentication key, length limited to [1, 128].
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }

        /// <summary>
        /// Authentication username, length limited to [1, 128].
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Authentication password, length limited to [1, 128].
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// The destination type for relay. Available values: Standard, AWS_MediaPackageV1, AWS_MediaPackageV2. Default: Standard. AWS_AmazonS3 or COS is supported when FrameCapture group is selected.
        /// </summary>
        [JsonProperty("DestinationType")]
        public string DestinationType{ get; set; }

        /// <summary>
        /// Forward the Aws S3 address information.
        /// </summary>
        [JsonProperty("AmazonS3Settings")]
        public AmazonS3Settings AmazonS3Settings{ get; set; }

        /// <summary>
        /// Forward COS address information.
        /// </summary>
        [JsonProperty("CosSettings")]
        public CosSettings CosSettings{ get; set; }


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
            this.SetParamObj(map, prefix + "AmazonS3Settings.", this.AmazonS3Settings);
            this.SetParamObj(map, prefix + "CosSettings.", this.CosSettings);
        }
    }
}

