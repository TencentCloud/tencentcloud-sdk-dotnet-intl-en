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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddAssetImageRegistryRegistryDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Repository name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Repository URL
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Repository type. Valid values: harbor, quay, jfrog, aws, azure, and other-tcr.
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// Network type, which can be `public` (public network).
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// Repository version
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// Region. Default value: `default`.
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// Speed limit
        /// </summary>
        [JsonProperty("SpeedLimit")]
        public long? SpeedLimit{ get; set; }

        /// <summary>
        /// Valid values: `0` (secure mode with certificate verification, which is the default value); `1` (unsecure mode that skips certificate verification).
        /// </summary>
        [JsonProperty("Insecure")]
        public ulong? Insecure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnDetectConfig")]
        public ConnDetectConfig[] ConnDetectConfig{ get; set; }

        /// <summary>
        /// Whether authorization and scanning are performed automatically. For full synchronization, only images of the latest version are involved. For incremental synchronization, all new images are involved.
        /// </summary>
        [JsonProperty("NeedScan")]
        public bool? NeedScan{ get; set; }

        /// <summary>
        /// Synchronization method. 0: full synchronization; 1: incremental synchronization.
        /// </summary>
        [JsonProperty("SyncMode")]
        public ulong? SyncMode{ get; set; }

        /// <summary>
        /// Webhook access address.
        /// </summary>
        [JsonProperty("WebhookUrl")]
        public string WebhookUrl{ get; set; }

        /// <summary>
        /// Webhook access token.
        /// </summary>
        [JsonProperty("WebhookToken")]
        public string WebhookToken{ get; set; }

        /// <summary>
        /// TCR instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegistryVersion", this.RegistryVersion);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "SpeedLimit", this.SpeedLimit);
            this.SetParamSimple(map, prefix + "Insecure", this.Insecure);
            this.SetParamArrayObj(map, prefix + "ConnDetectConfig.", this.ConnDetectConfig);
            this.SetParamSimple(map, prefix + "NeedScan", this.NeedScan);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "WebhookUrl", this.WebhookUrl);
            this.SetParamSimple(map, prefix + "WebhookToken", this.WebhookToken);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

