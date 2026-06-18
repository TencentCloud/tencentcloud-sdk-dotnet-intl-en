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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoleInfo : AbstractModel
    {
        
        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// HostIP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// Original IP
        /// </summary>
        [JsonProperty("OriginIP")]
        public string OriginIP{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// asset ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// city
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Province
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// nation
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// latitude
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// longitude
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// Information.
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// Domain
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Enterprise Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// Family Group
        /// </summary>
        [JsonProperty("Family")]
        public string Family{ get; set; }

        /// <summary>
        /// Virus name
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// MD5 Value
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }

        /// <summary>
        /// Malicious process filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 1-Host Assets; 2-Domain Assets; 3-Network Assets
        /// </summary>
        [JsonProperty("AssetType")]
        public long? AssetType{ get; set; }

        /// <summary>
        /// Information Fields of Source Log Analysis
        /// </summary>
        [JsonProperty("FromLogAnalysisData")]
        public KeyValue[] FromLogAnalysisData{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// container ID
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "OriginIP", this.OriginIP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Family", this.Family);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamArrayObj(map, prefix + "FromLogAnalysisData.", this.FromLogAnalysisData);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
        }
    }
}

