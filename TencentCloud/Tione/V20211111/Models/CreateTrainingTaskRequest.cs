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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTrainingTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Training task name. The name cannot exceed 60 characters in length, and can contain only Chinese characters, letters, digits, underscores (_), and hyphens (-). It must start with a Chinese character, letter, or digit.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Billing mode. For example, PREPAID indicates yearly/monthly subscription (resource group).
        /// POSTPAID_BY_HOUR indicates pay-as-you-go mode.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// Resource configuration. Specify the CVM instance specification ID and number of nodes. The API for querying the CVM instance specification ID is DescribeBillingSpecsPrice. For example, [{"Role":"WORKER", "InstanceType": "TI.S.MEDIUM.POST", "InstanceNum": 1}].
        /// </summary>
        [JsonProperty("ResourceConfigInfos")]
        public ResourceConfigInfo[] ResourceConfigInfos{ get; set; }

        /// <summary>
        /// TI Workspace ID. Used solely for the "Workspace" allowlist feature. To use this feature, please contact a TI administrator to enable allowlisting.
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// Training framework name, which can be queried via the DescribeTrainingFrameworks API. For example, SPARK, PYSPARK, TENSORFLOW, and PYTORCH.
        /// </summary>
        [JsonProperty("FrameworkName")]
        public string FrameworkName{ get; set; }

        /// <summary>
        /// Training framework version, which can be queried via the DescribeTrainingFrameworks API. For example, 1.15 and 1.9.
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// Training framework environment, which can be queried via the DescribeTrainingFrameworks API. For example, tf1.15-py3.7-cpu and torch1.9-py3.8-cuda11.1-gpu.
        /// </summary>
        [JsonProperty("FrameworkEnvironment")]
        public string FrameworkEnvironment{ get; set; }

        /// <summary>
        /// ID of the prepaid dedicated resource group, which can be queried via the DescribeBillingResourceGroups API.
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// Tag configuration.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Custom image information.
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// COS code package path.
        /// </summary>
        [JsonProperty("CodePackagePath")]
        public CosPathInfo CodePackagePath{ get; set; }

        /// <summary>
        /// Task startup command. Specify this parameter based on the task training mode. If the configuration fails due to special characters, use the EncodedStartCmdInfo parameter instead.
        /// </summary>
        [JsonProperty("StartCmdInfo")]
        public StartCmdInfo StartCmdInfo{ get; set; }

        /// <summary>
        /// Training mode, which can be queried via the DescribeTrainingFrameworks API. For example, PS_WORKER, DDP, MPI, and HOROVOD.
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// Data configurations. This parameter depends on the DataSource field. The maximum number of configurations is 10.
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// VPC Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// COS training output path.
        /// </summary>
        [JsonProperty("Output")]
        public CosPathInfo Output{ get; set; }

        /// <summary>
        /// CLS logging configuration.
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// Tuning parameters. The value of this parameter cannot exceed 2048 characters in length.
        /// </summary>
        [JsonProperty("TuningParameters")]
        public string TuningParameters{ get; set; }

        /// <summary>
        /// Indicates whether to report logs.
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// Remarks. The value of this parameter cannot exceed 1024 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Data source. For example, DATASET, COS, CFS, CFSTurbo, HDFS, and GooseFSx.
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// Callback URL. This parameter is used for the asynchronous callback to create, start, or stop training tasks. For the callback format and content, see [[TI-ONE API Callback Description]](https://www.tencentcloud.com/document/product/851/84292?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// Encoded task startup command. If StartCmdInfo is also configured, only this parameter takes effect.
        /// </summary>
        [JsonProperty("EncodedStartCmdInfo")]
        public EncodedStartCmdInfo EncodedStartCmdInfo{ get; set; }

        /// <summary>
        /// Code repository configuration.
        /// </summary>
        [JsonProperty("CodeRepos")]
        public CodeRepoConfig[] CodeRepos{ get; set; }

        /// <summary>
        /// Network exposure configuration.
        /// </summary>
        [JsonProperty("ExposeNetworkConfig")]
        public ExposeNetworkConfig ExposeNetworkConfig{ get; set; }

        /// <summary>
        /// Environment Variables.
        /// </summary>
        [JsonProperty("Envs")]
        public EnvVar[] Envs{ get; set; }

        /// <summary>
        /// Train tool configuration.
        /// </summary>
        [JsonProperty("TrainToolConfig")]
        public TrainToolConfig TrainToolConfig{ get; set; }

        /// <summary>
        /// Training Diagnostic Tool Configuration.
        /// </summary>
        [JsonProperty("ResourceSupplyAttribute")]
        public ResourceSupplyAttribute ResourceSupplyAttribute{ get; set; }

        /// <summary>
        /// Queue ID.
        /// </summary>
        [JsonProperty("Queues")]
        public string[] Queues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamArrayObj(map, prefix + "ResourceConfigInfos.", this.ResourceConfigInfos);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "FrameworkName", this.FrameworkName);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamSimple(map, prefix + "FrameworkEnvironment", this.FrameworkEnvironment);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamObj(map, prefix + "CodePackagePath.", this.CodePackagePath);
            this.SetParamObj(map, prefix + "StartCmdInfo.", this.StartCmdInfo);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "TuningParameters", this.TuningParameters);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamObj(map, prefix + "EncodedStartCmdInfo.", this.EncodedStartCmdInfo);
            this.SetParamArrayObj(map, prefix + "CodeRepos.", this.CodeRepos);
            this.SetParamObj(map, prefix + "ExposeNetworkConfig.", this.ExposeNetworkConfig);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamObj(map, prefix + "TrainToolConfig.", this.TrainToolConfig);
            this.SetParamObj(map, prefix + "ResourceSupplyAttribute.", this.ResourceSupplyAttribute);
            this.SetParamArraySimple(map, prefix + "Queues.", this.Queues);
        }
    }
}

