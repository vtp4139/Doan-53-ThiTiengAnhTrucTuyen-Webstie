﻿using EnglishExamOnline.Shared.FormViewModels;
using EnglishExamOnline.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IContestScheduleClient
    {
        Task<IList<ContestScheduleVm>> GetContestSchedule();

        Task<IList<ContestScheduleVm>> GetContestSchedulesAvailabe();

        Task<ContestScheduleVm> GetContestSchedule(int id);

        Task<IList<ContestScheduleVm>> FindContestSchedule(ContestScheduleFormVm findObject);

        Task<ContestScheduleVm> PostContestSchedule(ContestScheduleFormVm contestSchedule);

        Task<ContestScheduleVm> PutContestSchedule(int id, ContestScheduleFormVm contestSchedule);

        Task<int> DeleteContestSchedule(int id);
    }
}
