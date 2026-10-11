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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDynamicInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Ray cluster name.</p>
        /// </summary>
        [JsonProperty("RayClusterName")]
        public string RayClusterName{ get; set; }

        /// <summary>
        /// <p>Ray cluster ID.</p>
        /// </summary>
        [JsonProperty("RayClusterId")]
        public long? RayClusterId{ get; set; }

        /// <summary>
        /// <p>Creation type.</p><p>Enumeration values:</p><ul><li>1: form creation</li><li>2: YAML creation</li></ul>
        /// </summary>
        [JsonProperty("SubmitType")]
        public long? SubmitType{ get; set; }

        /// <summary>
        /// <p>Namespace.</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>labels</p>
        /// </summary>
        [JsonProperty("Labels")]
        public NameValue[] Labels{ get; set; }

        /// <summary>
        /// <p>Tolerations</p>
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>Environment variable.</p>
        /// </summary>
        [JsonProperty("Env")]
        public NameValue[] Env{ get; set; }

        /// <summary>
        /// <p>Whether to rely on external Kerberos components.</p>
        /// </summary>
        [JsonProperty("SupportExternalKerberosService")]
        public bool? SupportExternalKerberosService{ get; set; }

        /// <summary>
        /// <p>Dependent Kerberos cluster.</p>
        /// </summary>
        [JsonProperty("KerberosCluster")]
        public string KerberosCluster{ get; set; }

        /// <summary>
        /// <p>token</p>
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// <p>HeadGroup</p>
        /// </summary>
        [JsonProperty("HeadGroupSpec")]
        public DynamicInstanceGroupSpec HeadGroupSpec{ get; set; }

        /// <summary>
        /// <p>WorkerGroup</p>
        /// </summary>
        [JsonProperty("WorkerGroupSpecs")]
        public DynamicInstanceGroupSpec[] WorkerGroupSpecs{ get; set; }

        /// <summary>
        /// <p>Whether to enable storage configuration.</p>
        /// </summary>
        [JsonProperty("StorageConfigEnabled")]
        public bool? StorageConfigEnabled{ get; set; }

        /// <summary>
        /// <p>Redis instance information.</p>
        /// </summary>
        [JsonProperty("RedisInstance")]
        public RedisInstance RedisInstance{ get; set; }

        /// <summary>
        /// <p>Image information.</p>
        /// </summary>
        [JsonProperty("CustomImage")]
        public CustomImage CustomImage{ get; set; }

        /// <summary>
        /// <p>Dashboard link.</p>
        /// </summary>
        [JsonProperty("DashboardUrl")]
        public string DashboardUrl{ get; set; }

        /// <summary>
        /// <p>Total number of Pods.</p>
        /// </summary>
        [JsonProperty("TotalPodCount")]
        public long? TotalPodCount{ get; set; }

        /// <summary>
        /// <p>Whether to support high availability.</p>
        /// </summary>
        [JsonProperty("HighAvailability")]
        public bool? HighAvailability{ get; set; }

        /// <summary>
        /// <p>Storage information.</p>
        /// </summary>
        [JsonProperty("PersistentVolume")]
        public PersistentVolume PersistentVolume{ get; set; }

        /// <summary>
        /// <p>rayClusterYamlJson</p>
        /// </summary>
        [JsonProperty("RayClusterYaml")]
        public string RayClusterYaml{ get; set; }

        /// <summary>
        /// <p>Image information.</p>
        /// </summary>
        [JsonProperty("ImageInfoV2")]
        public ImageInfoV2 ImageInfoV2{ get; set; }

        /// <summary>
        /// <p>Whether to enable log collection.</p>
        /// </summary>
        [JsonProperty("EnableHistoryServer")]
        public bool? EnableHistoryServer{ get; set; }

        /// <summary>
        /// <p>TensorBoard link.</p>
        /// </summary>
        [JsonProperty("TensorBoardUrl")]
        public string TensorBoardUrl{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RayClusterName", this.RayClusterName);
            this.SetParamSimple(map, prefix + "RayClusterId", this.RayClusterId);
            this.SetParamSimple(map, prefix + "SubmitType", this.SubmitType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamSimple(map, prefix + "SupportExternalKerberosService", this.SupportExternalKerberosService);
            this.SetParamSimple(map, prefix + "KerberosCluster", this.KerberosCluster);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamObj(map, prefix + "HeadGroupSpec.", this.HeadGroupSpec);
            this.SetParamArrayObj(map, prefix + "WorkerGroupSpecs.", this.WorkerGroupSpecs);
            this.SetParamSimple(map, prefix + "StorageConfigEnabled", this.StorageConfigEnabled);
            this.SetParamObj(map, prefix + "RedisInstance.", this.RedisInstance);
            this.SetParamObj(map, prefix + "CustomImage.", this.CustomImage);
            this.SetParamSimple(map, prefix + "DashboardUrl", this.DashboardUrl);
            this.SetParamSimple(map, prefix + "TotalPodCount", this.TotalPodCount);
            this.SetParamSimple(map, prefix + "HighAvailability", this.HighAvailability);
            this.SetParamObj(map, prefix + "PersistentVolume.", this.PersistentVolume);
            this.SetParamSimple(map, prefix + "RayClusterYaml", this.RayClusterYaml);
            this.SetParamObj(map, prefix + "ImageInfoV2.", this.ImageInfoV2);
            this.SetParamSimple(map, prefix + "EnableHistoryServer", this.EnableHistoryServer);
            this.SetParamSimple(map, prefix + "TensorBoardUrl", this.TensorBoardUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

