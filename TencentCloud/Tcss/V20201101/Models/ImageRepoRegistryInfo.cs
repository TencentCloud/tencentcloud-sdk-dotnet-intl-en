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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRepoRegistryInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegistryId")]
        public ulong? RegistryId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegistryVersion")]
        public string RegistryVersion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnectMsg")]
        public string ConnectMsg{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnDetectType")]
        public string ConnDetectType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnDetectHostCount")]
        public ulong? ConnDetectHostCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnDetectDetail")]
        public RegistryConnDetectResult[] ConnDetectDetail{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LatestSyncTime")]
        public string LatestSyncTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SyncFailReason")]
        public string SyncFailReason{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SyncSolution")]
        public string SyncSolution{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SyncMessage")]
        public string SyncMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "RegistryVersion", this.RegistryVersion);
            this.SetParamSimple(map, prefix + "ConnectMsg", this.ConnectMsg);
            this.SetParamSimple(map, prefix + "ConnDetectType", this.ConnDetectType);
            this.SetParamSimple(map, prefix + "ConnDetectHostCount", this.ConnDetectHostCount);
            this.SetParamArrayObj(map, prefix + "ConnDetectDetail.", this.ConnDetectDetail);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "LatestSyncTime", this.LatestSyncTime);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncFailReason", this.SyncFailReason);
            this.SetParamSimple(map, prefix + "SyncSolution", this.SyncSolution);
            this.SetParamSimple(map, prefix + "SyncMessage", this.SyncMessage);
        }
    }
}

