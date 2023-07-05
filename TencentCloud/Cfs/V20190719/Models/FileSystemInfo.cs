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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileSystemInfo : AbstractModel
    {
        
        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Custom name
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// File system ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// File system status. Valid values:
        /// - creating
        /// - mounting
        /// - create_failed
        /// - available
        /// - unserviced
        /// - upgrading
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// Used file system capacity
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// Maximum storage limit of a file system
        /// </summary>
        [JsonProperty("SizeLimit")]
        public ulong? SizeLimit{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// File system protocol type
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// File system storage class
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Prepaid storage pack bound with the file system
        /// </summary>
        [JsonProperty("StorageResourcePkg")]
        public string StorageResourcePkg{ get; set; }

        /// <summary>
        /// Prepaid bandwidth pack bound to a file system (not supported currently)
        /// </summary>
        [JsonProperty("BandwidthResourcePkg")]
        public string BandwidthResourcePkg{ get; set; }

        /// <summary>
        /// Information of permission groups bound to a file system
        /// </summary>
        [JsonProperty("PGroup")]
        public PGroup PGroup{ get; set; }

        /// <summary>
        /// Custom name
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// Whether a file system is encrypted
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// Key used for encryption, which can be the key ID or ARN
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// The upper limit on the file system’s throughput, which is determined based on its current usage, and bound resource packs for both storage and throughput
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public float? BandwidthLimit{ get; set; }

        /// <summary>
        /// Total capacity of the file system
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// File system tag list
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// The lifecycle management status of a file system.
        /// </summary>
        [JsonProperty("TieringState")]
        public string TieringState{ get; set; }

        /// <summary>
        /// The details about tiered storage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TieringDetail")]
        public TieringDetailInfo TieringDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "SizeLimit", this.SizeLimit);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageResourcePkg", this.StorageResourcePkg);
            this.SetParamSimple(map, prefix + "BandwidthResourcePkg", this.BandwidthResourcePkg);
            this.SetParamObj(map, prefix + "PGroup.", this.PGroup);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TieringState", this.TieringState);
            this.SetParamObj(map, prefix + "TieringDetail.", this.TieringDetail);
        }
    }
}

