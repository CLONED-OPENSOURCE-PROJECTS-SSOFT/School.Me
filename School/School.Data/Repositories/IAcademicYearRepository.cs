﻿namespace School.Data.Repositories
{
    using System;
    using School.Models;

    public interface IAcademicYearRepository : IDeletableEntityRepository<AcademicYear>
    {
        bool ExistsInDb(DateTime startDate, DateTime endDate);
    }
}
