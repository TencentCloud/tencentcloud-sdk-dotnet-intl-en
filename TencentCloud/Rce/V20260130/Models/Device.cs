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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// <p>The unique id of device returned by RCE</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>The version of the application</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>Device brand</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>Client IP address</p>
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// <p>Device model</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>Network type of the device</p>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>The package name of the application</p>
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// <p>Device platform</p><p>Enumeration value:</p><ul><li>2: Android</li><li>3: IOS</li><li>4: H5</li><li>5: WeChat Mini Program</li></ul>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>Device system version</p>
        /// </summary>
        [JsonProperty("SystemVersion")]
        public string SystemVersion{ get; set; }

        /// <summary>
        /// <p>The build version of SDK</p>
        /// </summary>
        [JsonProperty("SdkBuildVersion")]
        public string SdkBuildVersion{ get; set; }

        /// <summary>
        /// <p>Signature verification token. Please contact us to enable signature verification</p>
        /// </summary>
        [JsonProperty("SignToken")]
        public string SignToken{ get; set; }

        /// <summary>
        /// <p>Token generation timestamp, in milliseconds</p>
        /// </summary>
        [JsonProperty("TokenTime")]
        public string TokenTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "SystemVersion", this.SystemVersion);
            this.SetParamSimple(map, prefix + "SdkBuildVersion", this.SdkBuildVersion);
            this.SetParamSimple(map, prefix + "SignToken", this.SignToken);
            this.SetParamSimple(map, prefix + "TokenTime", this.TokenTime);
        }
    }
}

