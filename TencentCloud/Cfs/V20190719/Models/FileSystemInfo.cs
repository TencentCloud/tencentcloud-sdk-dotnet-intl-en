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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileSystemInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// <p>User-defined name.</p>
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// <p>File system ID.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>File system status. Valid values:</p><ul><li>creating: Creating</li><li>mounting: Mounting</li><li>create_failed: Failed to create</li><li>available: Available</li><li>unserviced: Service suspended</li><li>upgrading: Upgrading</li></ul>
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// <p>Used capacity of the file system. Unit: Byte.</p>
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// <p>File system space limit. Unit: GiB.</p>
        /// </summary>
        [JsonProperty("SizeLimit")]
        public ulong? SizeLimit{ get; set; }

        /// <summary>
        /// <p>Region ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>Region name.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>File system protocol type. Valid values: NFS, CIFS, and TURBO.</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Storage type. Valid values: HP: General performance; SD: General standard; TP: turbo performance; TB: turbo standard; THP: Throughput.</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Prepaid storage pack bound to the file system.</p>
        /// </summary>
        [JsonProperty("StorageResourcePkg")]
        public string StorageResourcePkg{ get; set; }

        /// <summary>
        /// <p>Prepaid bandwidth pack bound to the file system (not supported yet).</p>
        /// </summary>
        [JsonProperty("BandwidthResourcePkg")]
        public string BandwidthResourcePkg{ get; set; }

        /// <summary>
        /// <p>Information of the permission group bound to the file system.</p>
        /// </summary>
        [JsonProperty("PGroup")]
        public PGroup PGroup{ get; set; }

        /// <summary>
        /// <p>User-defined name.</p>
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// <p>Whether the file system is encrypted. true: encrypted; false: not encrypted.</p>
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// <p>Key used for encryption, which can be the key ID or ARN.</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Maximum file system throughput, which is determined by the current used storage capacity of the file system, the bound storage pack, and the throughput pack. Unit: MiB/s.</p>
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public float? BandwidthLimit{ get; set; }

        /// <summary>
        /// <p>Snapshot policy associated with the file system.</p>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// <p>Snapshot processing status of the file system. snapping: snapshot in progress; normal: normal status.</p>
        /// </summary>
        [JsonProperty("SnapStatus")]
        public string SnapStatus{ get; set; }

        /// <summary>
        /// <p>Maximum capacity specification of the file system.<br>Unit: GiB.</p>
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// <p>List of file system tags.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Lifecycle management status of the file system.<br>NotAvailable: Unavailable.<br>Available: Available.</p>
        /// </summary>
        [JsonProperty("TieringState")]
        public string TieringState{ get; set; }

        /// <summary>
        /// <p>Tiered storage details.</p>
        /// </summary>
        [JsonProperty("TieringDetail")]
        public TieringDetailInfo TieringDetail{ get; set; }

        /// <summary>
        /// <p>Automatic scaling policy of the file system.</p>
        /// </summary>
        [JsonProperty("AutoScaleUpRule")]
        public AutoScaleUpRule AutoScaleUpRule{ get; set; }

        /// <summary>
        /// <p>File system version.</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Additional performance information.</p>
        /// </summary>
        [JsonProperty("ExstraPerformanceInfo")]
        public ExstraPerformanceInfo[] ExstraPerformanceInfo{ get; set; }

        /// <summary>
        /// <p>basic: standard metadata type.<br>enhanced: enhanced metadata type.</p>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>Business scenario.</p><p>Valid values:</p><ul><li>AgentSandbox: Create AgentCFS.</li></ul>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }

        /// <summary>
        /// <p>Overfull deletion capacity ratio. 0.0 indicates disabled.</p><p>Value range: [0.0, 1.0].</p>
        /// </summary>
        [JsonProperty("FullDeleteCapacityUsage")]
        public float? FullDeleteCapacityUsage{ get; set; }

        /// <summary>
        /// <p>Minimum survival time before overfull deletion, in seconds.</p><p>Unit: seconds.</p>
        /// </summary>
        [JsonProperty("FullDeleteMinTtl")]
        public ulong? FullDeleteMinTtl{ get; set; }

        /// <summary>
        /// <p>Expiration deletion TTL, in seconds. 0 indicates disabled.</p><p>Unit: seconds.</p>
        /// </summary>
        [JsonProperty("ExpireDeleteTtl")]
        public ulong? ExpireDeleteTtl{ get; set; }


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
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "SnapStatus", this.SnapStatus);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TieringState", this.TieringState);
            this.SetParamObj(map, prefix + "TieringDetail.", this.TieringDetail);
            this.SetParamObj(map, prefix + "AutoScaleUpRule.", this.AutoScaleUpRule);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArrayObj(map, prefix + "ExstraPerformanceInfo.", this.ExstraPerformanceInfo);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
            this.SetParamSimple(map, prefix + "FullDeleteCapacityUsage", this.FullDeleteCapacityUsage);
            this.SetParamSimple(map, prefix + "FullDeleteMinTtl", this.FullDeleteMinTtl);
            this.SetParamSimple(map, prefix + "ExpireDeleteTtl", this.ExpireDeleteTtl);
        }
    }
}

